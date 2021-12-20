using System.ComponentModel.DataAnnotations;

namespace BlazorMeetup.Data
{
    public class AvatarSettings
    {
        public string Id { get; set; }
        public string AvatarUrl { get; set; }
        public string AvatarIdentification { get; set; }

        public virtual Attendee Attendee { get; set; }
        public string AttendeeId { get; set; }
        public int Size { get; set; } = 100;
        public int Left { get; set; } = 0;
        public int Top { get; set; } = 0;
    }
}
