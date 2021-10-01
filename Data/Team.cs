﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMeetup.Data
{
    public class Team
    {
        public string Id { get; set; }
        public string EventId { get; set; }
        public string Name { get; set; }
        public ICollection<TeamAttendee> Attendees  { get; set; } 

        public Team()
        {
            this.Attendees = new HashSet<TeamAttendee>();
        }
    }
}