using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMeetup.Data
{
    public class TeamAttendee
    {
        public string Id { get; set; }
        public string TeamId { get; set; }
        public string AttendeeId { get; set; }
    }
}
