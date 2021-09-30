using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMeetup.Data
{
    public class Attendee : IdentityUser
    {
        public ICollection<AttendeeEvent> Events { get; set; }
        public ICollection<SuggestedDateAttendee> SuggestedDates { get; set; }

       
        public Attendee()
        {
            this.Events = new HashSet<AttendeeEvent>();
        }
    }
}
