using BlazorMeetup.Areas.Identity;
using BlazorMeetup.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System;


namespace BlazorMeetup
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<Attendee>>();
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddSingleton<TokenProvider>();
            services.AddAuthentication(o => o.DefaultChallengeScheme = "Discord").AddDiscord(options =>
            {
                options.Scope.Add("identify");
                options.Scope.Add("email");
                options.Scope.Add("guilds");
                options.ClientId = Configuration["Discord:AppId"];
                options.ClaimActions.MapJsonKey("urn:discord:discriminator", "discriminator", ClaimValueTypes.UInteger32);
                options.ClaimActions.MapJsonKey("urn:discord:avatar", "avatar", ClaimValueTypes.String);
                options.ClaimActions.MapJsonKey("urn:discord:verified", "verified", ClaimValueTypes.Boolean);

                options.ClientSecret = Configuration["Discord:AppSecret"];
                options.SaveTokens = true;
                options.Events = new OAuthEvents
                {

                    OnCreatingTicket = ctx =>
                    {
                        List<AuthenticationToken> tokens = ctx.Properties.GetTokens().ToList();
                        TokenProvider tokenProvider = new();
                        tokenProvider.AccessToken = tokens.Where(x => x.Name == "access_token").ToList().First().Value;
                        tokenProvider.RefreshToken = tokens.Where(x => x.Name == "refresh_token").ToList().First().Value;
                        var result = ctx.Identity.Claims.Where(x => x.Type == ClaimTypes.Email).ToList().FirstOrDefault();
                        StaticTokenHolder.loggedInStatus.TryAdd(result.Value, true);
                        StaticTokenHolder.tokens.TryAdd(result.Value, tokenProvider);
                        ctx.Properties.StoreTokens(tokens);

                        return Task.CompletedTask;
                    },
                    OnRemoteFailure = context =>
                    {
                        context.Response.Redirect("/");
                        context.HandleResponse();

                        return Task.FromResult(0);
                    }
                };
            }

            );

            services.AddScoped<MeetupService>();
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 1;
                options.Password.RequiredUniqueChars = 1;
            });


            services.AddScoped<CreateUsers>();
            services.AddSingleton<TeamsUpdateService>();
            services.AddHttpClient();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, CreateUsers cu)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            cu.InitializeUsers();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
