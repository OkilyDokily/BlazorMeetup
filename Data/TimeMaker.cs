using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorMeetup.Data
{
    public class TimeMaker
    {
        public int Hours { get; set; }
        public DateTime Date { get; set; } = DateTime.Today;
        public int Minutes { get; set; }

        public TimeMaker()
        {

        }

        public TimeMaker(List<int> hours)
        {

            Hours = hours.First();

        }

        public TimeMaker(List<int> hours, List<int> minutes)
        {

            Hours = hours.First();
            Minutes = minutes.First();
        }
        public DateTime MakeTime()
        {
            DateTime am = Date.AddMinutes(Minutes);
            DateTime ah = am.AddHours(Hours);
            return ah;
        }

        public static List<int> GetHours(List<TimesAllowed> ta = null)
        {
            if (ta == null || ta.Count == 0)
                return Enumerable.Range(0, 24).ToList();

            List<int> er = new();

            foreach (TimesAllowed t in ta)
            {
                List<int> rfer = Enumerable.Range(t.BeginningHour, (t.EndingHour - t.BeginningHour) + 1).ToList();

                foreach (int r in rfer)
                {
                    if (er.Any(x => x == r))
                    {
                        continue;
                    }
                    er.Add(r);
                }
            }
            return er;
        }

        public static List<int> GetMinutes(int hour = -1, List<TimesAllowed> ta = null)
        {
            if (ta == null || hour == -1 || ta.Count == 0)
                return new List<int>() { 0, 15, 30, 45 };
            List<int> mr = new List<int>() { 0, 15, 30, 45 };
            foreach (TimesAllowed t in ta)
            {
                List<int> rfer = Enumerable.Range(t.BeginningHour, (t.EndingHour - t.BeginningHour) + 1).ToList();
                if (rfer.Any(x => x == hour))
                {
                    if (!(rfer.First() == hour) && !(rfer.Last() == hour))
                    {
                        return new List<int>() { 0, 15, 30, 45 };
                    }

                    if ((rfer.First() == hour) && (rfer.Last() == hour))
                    {
                        return mr.Where(x => x >= t.BeginningMinute && x < t.EndingMinute).ToList();
                    }
                    if (rfer.First() == hour)
                    {
                        return mr.Where(x => x >= t.BeginningMinute).ToList();
                    }
                    if (rfer.Last() == hour)
                    {
                        return mr.Where(x => x <= t.EndingMinute).ToList();
                    }
                }
            }
            return mr;
        }
    }
}
