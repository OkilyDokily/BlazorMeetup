using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BlazorMeetup.Data
{


        public class AttendeeEvent
        {
            public int AttendeeEventId { get; set; }
            public int AttendeeId { get; set; }
            public int EventId { get; set; }
            public virtual Attendee Attendee { get; set; }
            public virtual Event Event { get; set; }
        }
 
}
