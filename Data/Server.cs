using System.Collections.Generic;

namespace BlazorMeetup.Data
{
    public class Server
    {
        public string Id { get; set; }
        public string AttendeeId { get; set; }
        public virtual Attendee Attendee { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public bool Owner { get; set; }
        public int Permissions { get; set; }
        public string Permissions_new { get; set; }
        public Server()
        {
            this.Events = new HashSet<Event>();
        }
    }
}
