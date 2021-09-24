using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMeetup.Data
{
    public class RestrictDate
    {
        public string Id { get; set; }
        public string EventId { get; set; }
        public DateTime Date { get; set; }
    }
}
