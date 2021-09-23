using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Net.Http;
using System.Diagnostics;

namespace BlazorMeetup.Data
{
    public class MeetupService
    { 
        private readonly IDbContextFactory<BlazorMeetupContext> _dbContextFactory;

        public MeetupService(IDbContextFactory<BlazorMeetupContext> factory)
        {
            _dbContextFactory = factory;
        }


        public bool AttendeeEventExists(string attendeeId, string eventId)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                AttendeeEvent ae = ctx.AttendeeEvents.FirstOrDefault(x=>x.AttendeeId == attendeeId && x.EventId == eventId);
                if (ae == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public void ChangeProposedDate(Event eventerino)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                ctx.Update(eventerino);
                ctx.SaveChanges();
                List<AttendeeEvent> aes = eventerino.Attendees.ToList();
                foreach(AttendeeEvent a in aes)
                {
                    a.CanAttendProposedDate = false;
                    ctx.Update(a);
                    ctx.SaveChanges();
                }
            }
        }

        public bool CanAttend(SuggestedDate sd,string loggedInId)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                SuggestedDateAttendee sdae = GetSuggestedDateAttendee(sd, loggedInId);
                if(sdae == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public void AddSuggestedDateToAttendees(SuggestedDate sd, string loggedInId)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                if (GetSuggestedDateAttendee(sd, loggedInId) == null)
                {
                   
                    SuggestedDateAttendee sdae = new SuggestedDateAttendee()
                    {
                        Id = Guid.NewGuid().ToString(),
                        SuggestedDateId = sd.Id,
                        AttendeeId = loggedInId
                    };
                    ctx.SuggestedDateAttendees.Add(sdae);
                    ctx.SaveChanges();
                }
            }
             
        }

        SuggestedDateAttendee GetSuggestedDateAttendee(SuggestedDate sd, string loggedInId)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                Attendee a = ctx.Attendees.FirstOrDefault(x => x.Id == loggedInId);
                SuggestedDateAttendee sdae = ctx.SuggestedDateAttendees.FirstOrDefault(x => x.AttendeeId == a.Id && x.SuggestedDateId == sd.Id);
                return sdae;
            }
                
        }

        public void RemoveSuggestedDateFromAttendees(SuggestedDate sd,string loggedInId)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {

                SuggestedDateAttendee sdae = GetSuggestedDateAttendee(sd,loggedInId);
                ctx.SuggestedDateAttendees.Remove(sdae);
                ctx.SaveChanges();
            }
             
        }

        public void SuggestDate(SuggestedDate s)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                s.Id = Guid.NewGuid().ToString();
                ctx.SuggestedDates.Add(s);
                ctx.SaveChanges();
            }
        }

        public List<Attendee> GetAllUsers()
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                return ctx.Attendees.ToList();
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

        public void DeleteEvent(Event eventToRemove)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {    
                ctx.Events.Remove(eventToRemove);
                ctx.SaveChanges();
            }
        }

        public void LeaveEvent(string userId,string eventId)
        {
            using (var ctx = _dbContextFactory.CreateDbContext()) 
            {
                AttendeeEvent ae = ctx.AttendeeEvents.FirstOrDefault(x=> x.EventId == eventId && x.Attendee.Id == userId);
                if(ae != null)
                {
                    ctx.AttendeeEvents.Remove(ae);
                    ctx.SaveChanges();
                }   
            }
        }

        public void JoinEvent(string id,string eventId)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {         
                AttendeeEvent ae = ctx.AttendeeEvents.FirstOrDefault(x => x.Id == id && x.EventId == eventId);
                if(ae==null)
                {
                    ctx.AttendeeEvents.Add(new AttendeeEvent { Id = Guid.NewGuid().ToString(), AttendeeId = id, EventId = eventId });
                    ctx.SaveChanges();
                }   
            }
        }

        public List<Event> GetYourEvents(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                return ctx.Events.Where(x => x.AttendeeId == id).ToList();         
            }
        }

        public Event GetEventById(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                return ctx.Events.Include(x=>x.SuggestedDates).Include(x=>x.Attendee).Include(x=>x.Attendees).FirstOrDefault(x => x.Id == id);   
            }
        }

        public void ChangeCanAttendInitialDate(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                AttendeeEvent ae = ctx.AttendeeEvents.FirstOrDefault(x => x.Id == id);
                ae.CanAttendProposedDate = !ae.CanAttendProposedDate;
                ctx.SaveChanges();
                
            }
        }

        public List<Attendee> GetAvailableUsers(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                SuggestedDate sd = ctx.SuggestedDates.Include(x => x.Attendees).ThenInclude(x=>x.Attendee).FirstOrDefault(x=> x.Id == id);
                return sd.Attendees.Select(x => x.Attendee).ToList();
            }
        }

        public SuggestedDate GetSuggestedDateById(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                SuggestedDate sd = ctx.SuggestedDates.FirstOrDefault(x=>x.Id == id);
                return sd;
            }
        }
    }
}