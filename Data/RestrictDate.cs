using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorMeetup.Data
{
    public class RestrictDate
    {
        public string Id { get; set; }

        public string EventId { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public virtual Event Event { get; set; }
        public virtual ICollection<TimesAllowed> TimesAlloweds { get; set; }
        public virtual ICollection<SuggestedDate> SuggestedDates { get; set; }

        public RestrictDate()
        {
            this.SuggestedDates = new HashSet<SuggestedDate>();
            this.TimesAlloweds = new HashSet<TimesAllowed>();
        }

    }
}
