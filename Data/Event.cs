using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BlazorMeetup.Data
{
    public class Event
    {
        public int EventId { get; set; }
        public IdentityUser EventOwner { get; set; }
        public string Descriptions { get; set; }
        public int MaximumAttendees { get; set; }

        public virtual ICollection<AttendeeEvent> Attendees { get; set; }

        public DateTime DateAndTime { get; set; }

    }
}
