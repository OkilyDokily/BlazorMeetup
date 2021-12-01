using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorMeetup.Data
{
    public class Event
    {
        public string Id { get; set; }
        public string AttendeeId { get; set; }
        [Required]
        public string Description { get; set; }
        public int MaximumAttendees { get; set; }
        public int MinimumAttendees { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        [Required]
        public string ServerId { get; set; }
        public virtual Server Server { get; set; }
        public virtual ICollection<AttendeeEvent> Attendees { get; set; }
        public virtual Attendee Attendee { get; set; }
        public virtual ICollection<RestrictDate> RestrictDates { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
        public DateTime DateAndTime { get; set; }
        public Event()
        {
            this.Attendees = new HashSet<AttendeeEvent>();
            this.RestrictDates = new HashSet<RestrictDate>();
        }
    }
}
