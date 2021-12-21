using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMeetup.Data
{
    public class UpdateServers
    {
        public void RemoveDelegate(Func<Task> myDelegate)
        {
            UpdateEvents -= myDelegate;
        }
        public void InvokeUpdate()
        {
            try
            {
                UpdateEvents.GetInvocationList();
            }
            catch
            {
                return;
            }
            foreach (var del in UpdateEvents.GetInvocationList())
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

        public void AddEvent(Func<Task> newDelegate)
        {
            UpdateEvents += newDelegate;
        }

        public Func<Task> UpdateEvents;

    }
}
