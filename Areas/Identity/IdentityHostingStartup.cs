using System;
using BlazorMeetup.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

[assembly: HostingStartup(typeof(BlazorMeetup.Areas.Identity.IdentityHostingStartup))]
namespace BlazorMeetup.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {

        public void Configure(IWebHostBuilder builder)
        {

            builder.ConfigureServices((context, services) =>
            {

                var connectionString = context.Configuration.GetConnectionString("MyDbConnection");

                Console.WriteLine(connectionString + "dsfadsfadsf");
                services.AddDbContextFactory<BlazorMeetupContext>(item => item.UseSqlServer(connectionString));
                services.AddDbContext<BlazorMeetupContext>(options =>
                    options.UseSqlServer(connectionString));

                services.AddDefaultIdentity<Attendee>(options => options.SignIn.RequireConfirmedAccount = false).AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<BlazorMeetupContext>();

            });
        }
    }
}
