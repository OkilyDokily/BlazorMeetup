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

       
        private readonly IDbContextFactory<BlazorMeetupContext> _dbContextFactory;

        public MeetupService(IDbContextFactory<BlazorMeetupContext> factory)
        {
           
            _dbContextFactory = factory;
        }

        public List<IdentityUser> GetAllUsers()
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                return ctx.Users.ToList();
            }
        }
        public void CreateEvent(Event create)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                create.Id = Guid.NewGuid().ToString();
                ctx.Events.Add(create);
                ctx.SaveChanges();
            }
        }

        public void JoinEvent(string id,string eventId)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                Attendee attendee;
                if (!(ctx.Attendees.Any(x => x.IdentityUserId == id)))               
                {  
                    attendee = new Attendee()
                    {
                        Id = Guid.NewGuid().ToString(),
                        IdentityUserId = id
                    };
                    ctx.Attendees.Add(attendee);
                    ctx.SaveChanges();
                }
                else
                {
                    attendee = ctx.Attendees.FirstOrDefault(x => x.IdentityUserId == id);
                }

                AttendeeEvent ae = ctx.AttendeeEvents.FirstOrDefault(x => x.AttendeeId == attendee.Id && x.EventId == eventId);
                if(ae==null)
                {
                    ctx.AttendeeEvents.Add(new AttendeeEvent { Id = Guid.NewGuid().ToString(), AttendeeId = attendee.Id, EventId = eventId });
                    ctx.SaveChanges();
                }   
            }
        }

        public List<Event> GetYourEvents(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                return ctx.Events.Where(x => x.IdentityUserId == id).ToList();         
            }
        }

        public Event GetEventById(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                return ctx.Events.Include(x => x.Attendees).ThenInclude(x=>x.Attendee).ThenInclude(x=>x.IdentityUser).FirstOrDefault(x => x.Id == id);   
            }
        }

        public void ChangeCanAttendInitialDate(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {

                AttendeeEvent ae = ctx.AttendeeEvents.FirstOrDefault(x => x.Id == id);
                ae.CanAttendInitialDate = !ae.CanAttendInitialDate;
                ctx.SaveChanges();
                
            }
        }
    }
}