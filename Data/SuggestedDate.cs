using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMeetup.Data
{
    public class SuggestedDate
    {
        public string Id { get; set; }
        public string AttendeeId { get; set; }

        public Event Event { get; set; }

        public string EventId { get; set; }
        public DateTime DateTime { get; set; }
        public virtual RestrictDate RestrictDate { get; set; }
        public string RestrictDateId { get; set; }
        public virtual Attendee Attendee { get; set; }
        public virtual ICollection<SuggestedDateAttendee> Attendees { get; set; }

        public SuggestedDate()
        {
            this.Attendees = new HashSet<SuggestedDateAttendee>();
        }

    }
}
