using System.Collections.Generic;

namespace BlazorMeetup.Data
{
    public class Team
    {
        public string Id { get; set; }
        public string EventId { get; set; }
        public virtual Event Event { get; set; }
        public string Name { get; set; }
        public virtual TeamAvatarSettings TeamAvatarSettings { get; set; }
        public ICollection<TeamAttendee> Attendees { get; set; }


        public Team()
        {
            this.Attendees = new HashSet<TeamAttendee>();
        }
    }
}
