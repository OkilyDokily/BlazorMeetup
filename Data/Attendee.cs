using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMeetup.Data
{
    public class Attendee
    {
        public string Id { get; set; }
        public string IdentityUserId { get; set; }
        public ICollection<AttendeeEvent> Events { get; set; }

        public Attendee()
        {
            this.Events = new HashSet<AttendeeEvent>();
        }
    }
}
