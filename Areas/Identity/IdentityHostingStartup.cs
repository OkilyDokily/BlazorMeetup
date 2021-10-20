using System;
using BlazorMeetup.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BlazorMeetup.Areas.Identity.IdentityHostingStartup))]
namespace BlazorMeetup.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {

        public void Configure(IWebHostBuilder builder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 19));
            builder.ConfigureServices((context, services) =>
            {

                var connectionString = context.Configuration["ConnectionStrings:DefaultConnection"];

                services.AddDbContextFactory<BlazorMeetupContext>(item => item.UseMySql(connectionString, serverVersion));
                services.AddDbContext<BlazorMeetupContext>(item => item.UseMySql(connectionString, serverVersion));

                services.AddDefaultIdentity<Attendee>(options => options.SignIn.RequireConfirmedAccount = false).AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<BlazorMeetupContext>();

            });
        }
    }
}
