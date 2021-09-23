using System;
using BlazorMeetup.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BlazorMeetup.Areas.Identity.IdentityHostingStartup))]
namespace BlazorMeetup.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContextFactory<BlazorMeetupContext>(opt => opt.UseSqlite(context.Configuration.GetConnectionString("BlazorMeetupContextConnection")));
                services.AddDbContext<BlazorMeetupContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("BlazorMeetupContextConnection")));
               
                services.AddDefaultIdentity<Attendee>(options => options.SignIn.RequireConfirmedAccount = false).AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<BlazorMeetupContext>();
        
            });
        }
    }
}