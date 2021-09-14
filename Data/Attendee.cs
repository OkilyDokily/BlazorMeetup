using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMeetup.Data
{
    public class Attendee
    {
        public int AttendeeId { get; set; }
        public int IdentityUserId { get; set; }
        public ICollection<AttendeeEvent> Events { get; set; }

        public Attendee()
        {
            this.Events = new HashSet<AttendeeEvent>();
        }
    }
}
