using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMeetup.Data
{
    public class TimeMaker
    {
        public int Hours { get; set; }
        public DateTime Date { get; set; }

        public int Minutes { get; set; }

        public DateTime MakeTime()
        {            
           DateTime am = Date.AddMinutes(Minutes);
           DateTime ah = am.AddHours(Hours);
           return ah;
        }

        public List<int> GetHours()
        {
            return Enumerable.Range(1, 24).ToList();
        }

        public List<int> GetMinutes()
        {
            return new List<int>(){ 15,30,45};
        }
    }
}
