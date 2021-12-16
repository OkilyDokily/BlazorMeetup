using System.ComponentModel.DataAnnotations;

namespace BlazorMeetup.Data
{
    public class ServerAttendee
    {
        public string Id { get; set; }
        [Required]
        public virtual Server Server { get; set; }
        public virtual string ServerId { get; set; }
        [Required]
        public virtual Attendee Attendee { get; set; }
        public string AttendeeId { get; set; }
    }
}