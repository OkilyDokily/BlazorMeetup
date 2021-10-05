using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMeetup.Data
{
    public class AvatarSettings
    {
        public string Id { get; set; }
        public string FileName { get; set; }

        public int Size { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
    }
}
