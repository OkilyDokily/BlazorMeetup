using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace BlazorMeetup.Data
{
    public class Attendee : IdentityUser
    {
        public virtual ICollection<AttendeeEvent> Events { get; set; }
        public ICollection<SuggestedDateAttendee> SuggestedDates { get; set; }

        public virtual AvatarSettings AvatarSettings { get; set; }

        public virtual ICollection<TeamAttendee> Teams { get; set; }

        public Attendee()
        {
            this.Events = new HashSet<AttendeeEvent>();
            this.SuggestedDates = new HashSet<SuggestedDateAttendee>();
            this.Teams = new HashSet<TeamAttendee>();
        }
    }
}
