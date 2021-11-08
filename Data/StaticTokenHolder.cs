using System.Collections.Generic;
using System.Collections.Concurrent;

namespace BlazorMeetup.Data
{
    public class StaticTokenHolder
    {
        public static ConcurrentDictionary<string, TokenProvider> tokens = new();

    }
}