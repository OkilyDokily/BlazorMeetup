using System.Collections.Generic;

namespace BlazorMeetup.Data
{
    public class Team
    {
        public string Id { get; set; }
        public string EventId { get; set; }
        public virtual Event Event { get; set; }
        public string Name { get; set; }
        public string AvatarSettingsId { get; set; }
        public AvatarSettings AvatarSettings { get; set; }
        public ICollection<TeamAttendee> Attendees { get; set; }


        public Team()
        {
            this.Attendees = new HashSet<TeamAttendee>();
        }
    }
}
