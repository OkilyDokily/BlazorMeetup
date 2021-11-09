using System.Collections.Generic;

namespace BlazorMeetup.Data
{
    public class Server
    {
        public string Id { get; set; }
        public string AttendeeId { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public bool Owner { get; set; }
        public int Permissions { get; set; }
        public string Permissions_new { get; set; }
        public Server()
        {
            this.Events = new HashSet<Event>();
        }
    }
}
// "id": "143867839282020352",
//     "name": "C#",
//     "icon": "a_9792ff4af564d609736e178cd374de62",
//     "owner": false,
//     "permissions": 104189504,
//     "features": [
//       "ROLE_ICONS",
//       "NEW_THREAD_PERMISSIONS",
//       "BANNER",
//       "DISCOVERABLE",
//       "SEVEN_DAY_THREAD_ARCHIVE",
//       "ENABLED_DISCOVERABLE_BEFORE",
//       "NEWS",
//       "COMMERCE",
//       "WELCOME_SCREEN_ENABLED",
//       "ANIMATED_ICON",
//       "MEMBER_PROFILES",
//       "ANIMATED_BANNER",
//       "TEXT_IN_VOICE_ENABLED",
//       "THREE_DAY_THREAD_ARCHIVE",
//       "VANITY_URL",
//       "INVITE_SPLASH",
//       "PRIVATE_THREADS",
//       "PREVIEW_ENABLED",
//       "MEMBER_VERIFICATION_GATE_ENABLED",
//       "COMMUNITY",
//       "THREADS_ENABLED"
//     ],
//     "permissions_new": "1002979053120"
//   },