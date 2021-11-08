using System.Collections.Generic;

namespace BlazorMeetup.Data
{
    public class Server
    {
        public string Id { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public string Name { get; set; }
        public Server()
        {
            this.Events = new HashSet<Event>();
        }
    }
}