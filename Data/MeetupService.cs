using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Net.Http;

namespace BlazorMeetup.Data
{
    public class MeetupService
    {

        private readonly BlazorMeetupContext _appDBContext;
        private readonly IDbContextFactory<BlazorMeetupContext> _dbContextFactory;

        public MeetupService(BlazorMeetupContext appDBContext, IDbContextFactory<BlazorMeetupContext> factory)
        {
            _appDBContext = appDBContext;
            _dbContextFactory = factory;
        }

        public void CreateEvent(Event create)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                create.Id = Guid.NewGuid().ToString();
                _appDBContext.Events.Add(create);
                _appDBContext.SaveChanges();
            }
        }

        public void JoinEvent(string id,string eventId)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                Attendee attendee;
                if (!(_appDBContext.Attendees.Any(x => x.IdentityUserId == id)))
                
                {
                    
                    attendee = new Attendee()
                    {
                        Id = Guid.NewGuid().ToString(),
                        IdentityUserId = id
                    };
                    _appDBContext.Attendees.Add(attendee);
                    _appDBContext.SaveChanges();
                }
                else
                {
                    attendee = _appDBContext.Attendees.FirstOrDefault(x => x.IdentityUserId == id);
                }
                _appDBContext.AttendeeEvents.Add(new AttendeeEvent {Id= Guid.NewGuid().ToString(), AttendeeId = attendee.Id, EventId = eventId });
                _appDBContext.SaveChanges();
            }
        }

        public List<Event> GetYourEvents(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                return _appDBContext.Events.Where(x => x.IdentityUserId == id).ToList();         
            }
        }

        public Event GetEventById(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                return _appDBContext.Events.Include(x => x.Attendees).ThenInclude(x=>x.Attendee).ThenInclude(x=>x.IdentityUser).FirstOrDefault(x => x.Id == id);   
            }
        }
    }
}