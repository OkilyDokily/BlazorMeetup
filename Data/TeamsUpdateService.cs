using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMeetup.Data
{
    public class TeamsUpdateService
    {
        public void InvokeUpdate(string eventId)
        {
            UpdateEvents[eventId]?.Invoke();
        }

        public void AddEvent(string eventId,Func<Task> newDelegate)
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
