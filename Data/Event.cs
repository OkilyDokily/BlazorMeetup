using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BlazorMeetup.Data
{
    public class Event
    {
        public string Id { get; set; }
        public string IdentityUserId { get; set; }
        public string Description { get; set; }
        public int MaximumAttendees { get; set; }
        public int MinimumAttendees { get; set; }

        public virtual ICollection<AttendeeEvent> Attendees { get; set; }
        public virtual ICollection<SuggestedDate> SuggestedDates { get; set; }
        public virtual IdentityUser IdentityUser { get; set; }
        

        public DateTime DateAndTime { get; set; }
        public Event()
        {
            this.SuggestedDates = new HashSet<SuggestedDate>();
            this.Attendees = new HashSet<AttendeeEvent>();
        }

    }
}
