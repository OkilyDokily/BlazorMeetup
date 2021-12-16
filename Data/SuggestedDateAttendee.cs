using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorMeetup.Data
{
    public class SuggestedDateAttendee
    {
        public string Id { get; set; }
        public string AttendeeId { get; set; }
        public string SuggestedDateId { get; set; }

        public virtual SuggestedDate SuggestedDate { get; set; }
        [Required]

        public virtual Attendee Attendee { get; set; }


    }
}
