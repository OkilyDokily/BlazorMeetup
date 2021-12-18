using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BlazorMeetup.Data
{
    public class TeamAvatarSettings
    {
        public string Id { get; set; }
        public string AvatarUrl { get; set; }
        public string AvatarIdentification { get; set; }
        public string TeamId { get; set; }

        public virtual Team Team { get; set; }
        public int Size { get; set; } = 100;
        public int Left { get; set; } = 0;
        public int Top { get; set; } = 0;
    }
}
