using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMeetup.Data
{
    public class Team
    {
        public string Id { get; set; }
        Event EventId { get; set; }
        public ICollection<TeamAttendee> Attendees  { get; set; } 

        public Team()
        {
            this.Attendees = new HashSet<TeamAttendee>();
        }
    }
}
