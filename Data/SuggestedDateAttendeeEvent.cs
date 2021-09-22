using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMeetup.Data
{
    public class SuggestedDateAttendeeEvent
    {
        public string Id { get; set; }
        public string AttendeeEventId { get; set; }
        public string SuggestedDateId { get; set; }
        public virtual SuggestedDate SuggestedDate {get;set;}
        public virtual AttendeeEvent AttendeeEvent { get; set; }
        
        
    }
}
