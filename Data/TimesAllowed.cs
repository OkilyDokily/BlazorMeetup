﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMeetup.Data
{
    public class TimesAllowed
    {
        public string Id { get; set; }
        public int BeginningHour { get; set; }
        public int BeginningMinute { get; set; }
        public int EndingHour { get; set; }
        public int EndingMinute { get; set; }
        public string RestrictDateId { get; set; } 
    }
}
