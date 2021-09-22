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
        public string IdentityUserId { get; set; }
        public string EventId { get; set; }
     
        public DateTime DateTime { get; set; }
        public virtual IdentityUser IdentityUser { get; set; }
        public virtual Event Event { get; set; }
        public virtual ICollection<SuggestedDateAttendeeEvent> AttendeeEvents { get; set; }

        public SuggestedDate()
        {
            this.AttendeeEvents = new HashSet<SuggestedDateAttendeeEvent>();
        }

    }
}
