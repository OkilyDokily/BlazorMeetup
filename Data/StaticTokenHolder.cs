using System.Collections.Concurrent;

namespace BlazorMeetup.Data
{
    public class StaticTokenHolder
    {
        public static ConcurrentDictionary<string, bool> loggedInStatus = new();
        public static ConcurrentDictionary<string, TokenProvider> tokens = new();

    }
}