using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorMeetup.Data
{
    public class TeamAttendee
    {
        public string Id { get; set; }

        public string TeamId { get; set; }

        public string EventId { get; set; }
        public string AttendeeId { get; set; }
        [Required]
        public virtual Event Event { get; set; }

        public virtual Team Team { get; set; }

        public virtual Attendee Attendee { get; set; }
    }
}
