using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BlazorMeetup.Data
{
    public class AttendeeEvent
    {
        public string Id { get; set; }
        public string AttendeeId { get; set; }
        public string EventId { get; set; }
        public virtual Attendee Attendee { get; set; }
        public virtual Event Event { get; set; }
        public bool CanAttendProposedDate { get; set; }

       
    }
}
