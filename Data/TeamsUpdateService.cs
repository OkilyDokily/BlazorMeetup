using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMeetup.Data
{
    public class TeamsUpdateService
    {
        public void RemoveDelegate(string eventId, Func<Task> myDelegate)
        {
            UpdateEvents[eventId] -= myDelegate;
        }
        public void InvokeUpdate(string eventId)
        {

            if (!UpdateEvents.ContainsKey(eventId)) return;
            try
            {
                UpdateEvents[eventId].GetInvocationList();
            }
            catch
            {
                return;
            }
            foreach (var del in UpdateEvents[eventId].GetInvocationList())
            {
                try
                {
                    del.DynamicInvoke();
                }
                catch (Exception xx)
                {
                    Console.WriteLine(string.Format("Exception in {0}: {1}", del.Method.Name, xx.Message));
                }
                //https://csharp.2000things.com/tag/getinvocationlist/
            }
        }

        public void AddEvent(string eventId, Func<Task> newDelegate)
        {
            try
            {
                if (UpdateEvents.ContainsKey(eventId))
                {
                    UpdateEvents[eventId] += newDelegate;
                }
                else
                {
                    UpdateEvents.Add(eventId, newDelegate);
                }
            }
            catch
            {

            }
        }

        public Dictionary<string, Func<Task>> UpdateEvents = new();

    }
}
