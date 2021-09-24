using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorMeetup.Data
{
    public class BlazorMeetupContext : IdentityDbContext
    {
        public BlazorMeetupContext(DbContextOptions<BlazorMeetupContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Attendee> Attendees { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<AttendeeEvent> AttendeeEvents { get; set; }
        public virtual DbSet<SuggestedDate> SuggestedDates { get; set; }
        public virtual DbSet<RestrictDate> RestrictDates { get; set; }
        public virtual DbSet<SuggestedDateAttendee> SuggestedDateAttendees { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
