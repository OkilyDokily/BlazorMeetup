using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorMeetup.Data
{
    public class Attendee : IdentityUser
    {
        public virtual ICollection<AttendeeEvent> Events { get; set; }
        public virtual ICollection<ServerAttendee> Servers { get; set; }
        public ICollection<SuggestedDateAttendee> SuggestedDates { get; set; }

        public virtual AvatarSettings AvatarSettings { get; set; }

        public virtual ICollection<TeamAttendee> Teams { get; set; }

        public virtual ICollection<Event> EventsOwned { get; set; }
        public Attendee()
        {
            this.EventsOwned = new HashSet<Event>();
            this.Servers = new HashSet<ServerAttendee>();
            this.Events = new HashSet<AttendeeEvent>();
            this.SuggestedDates = new HashSet<SuggestedDateAttendee>();
            this.Teams = new HashSet<TeamAttendee>();
        }
    }
}
