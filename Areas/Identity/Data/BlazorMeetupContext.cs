using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

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
        public virtual DbSet<ServerAttendee> ServerAttendees { get; set; }
        public virtual DbSet<AttendeeEvent> AttendeeEvents { get; set; }
        public virtual DbSet<SuggestedDate> SuggestedDates { get; set; }
        public virtual DbSet<RestrictDate> RestrictDates { get; set; }
        public virtual DbSet<TimesAllowed> TimesAlloweds { get; set; }
        public virtual DbSet<SuggestedDateAttendee> SuggestedDateAttendees { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Server> Servers { get; set; }
        public virtual DbSet<TeamAttendee> TeamAttendees { get; set; }
        public virtual DbSet<AvatarSettings> AvatarSettings { get; set; }
        public virtual DbSet<TeamAvatarSettings> TeamAvatarSettings { get; set; }
        //new update 
        ///more update
        //and again
        //and again
        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     builder.Entity<SuggestedDate>().HasOne(x => x.RestrictDate).WithMany(x => x.SuggestedDates).OnDelete(DeleteBehavior.Cascade);


        //     builder.Entity<Server>().HasOne(x => x.Attendee).WithMany(x => x.Servers).OnDelete(DeleteBehavior.Cascade);

        //     builder.Entity<AvatarSettings>().HasOne<Attendee>().WithOne(x => x.AvatarSettings).OnDelete(DeleteBehavior.Cascade);

        //     builder.Entity<TeamAvatarSettings>().HasOne<Team>().WithOne(x => x.TeamAvatarSettings).OnDelete(DeleteBehavior.Cascade);

        //     builder.Entity<Event>().HasOne(x => x.Attendee).WithMany(x => x.EventsOwned).OnDelete(DeleteBehavior.Cascade);

        //     builder.Entity<SuggestedDateAttendee>().HasOne(x => x.Attendee).WithMany(x => x.SuggestedDates).OnDelete(DeleteBehavior.Cascade);

        //     builder.Entity<SuggestedDateAttendee>().HasOne(x => x.SuggestedDate).WithMany(x => x.Attendees).OnDelete(DeleteBehavior.Cascade);

        //     builder.Entity<TimesAllowed>().HasOne(x => x.RestrictDate).WithMany(x => x.TimesAlloweds).OnDelete(DeleteBehavior.Cascade);
        //     builder.Entity<RestrictDate>().HasOne(x => x.Event).WithMany(x => x.RestrictDates).OnDelete(DeleteBehavior.Cascade);
        //     builder.Entity<Team>().HasOne(x => x.Event).WithMany(x => x.Teams).OnDelete(DeleteBehavior.Cascade);
        //     //test
        //     builder.Entity<TeamAttendee>().HasOne(x => x.Team).WithMany(x => x.Attendees).OnDelete(DeleteBehavior.Cascade);
        //     builder.Entity<TeamAttendee>().HasOne(x => x.Attendee).WithMany(x => x.Teams).OnDelete(DeleteBehavior.Cascade);

        //     //test
        //     builder.Entity<AttendeeEvent>().HasOne(x => x.Attendee).WithMany(x => x.Events).OnDelete(DeleteBehavior.Cascade);
        //     builder.Entity<AttendeeEvent>().HasOne(x => x.Event).WithMany(x => x.Attendees).OnDelete(DeleteBehavior.Cascade);

        //     base.OnModelCreating(builder);

        //     // Customize the ASP.NET Identity model and override the defaults if needed.
        //     // For example, you can rename the ASP.NET Identity table names and more.
        //     // Add your customizations after calling base.OnModelCreating(builder);
        // }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {

        //     optionsBuilder.UseSqlServer(p => p.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
        //     optionsBuilder.
        //         ConfigureWarnings(w => w.Throw(RelationalEventId.MultipleCollectionIncludeWarning));
        //     optionsBuilder.
        //         ConfigureWarnings(w => w.Ignore(CoreEventId.RowLimitingOperationWithoutOrderByWarning));
        // }
    }
}
