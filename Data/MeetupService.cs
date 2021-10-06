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

        public AvatarSettings GetAvatarSettingsByUserId(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                return ctx.AvatarSettings.Where(x => x.AttendeeId == id).FirstOrDefault();
            }
        }
        public void AddAvatarSettings(AvatarSettings asetting)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                asetting.Id = Guid.NewGuid().ToString();
                ctx.AvatarSettings.Add(asetting);
                ctx.SaveChanges();
            }
        }
        public void UpdateAvatarSettings(AvatarSettings asetting)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                
                ctx.AvatarSettings.Update(asetting);
                ctx.SaveChanges();
            }
        }
        public void AddTimeAllowedToRestrictDate(TimesAllowed ta)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                ta.Id = Guid.NewGuid().ToString();
                ctx.TimesAlloweds.Add(ta);
                ctx.SaveChanges();
            }
        }

        public void AddRestrictDate(RestrictDate rd)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                rd.Id = Guid.NewGuid().ToString();
                ctx.RestrictDates.Add(rd);
                ctx.SaveChanges();
            }
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
                return ctx.Attendees.Include(x=>x.AvatarSettings).ToList();
            }
        }
        public void CreateEvent(Event create)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                if(create.Id != null)
                {
                    ctx.Events.Update(create);
                    ctx.SaveChanges();
                }
                else
                {
                    create.Id = Guid.NewGuid().ToString();
                    ctx.Events.Add(create);
                    ctx.SaveChanges();
                }
                
            }
        }

        public void DeleteEventById(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                Event eventToRemove = ctx.Events.Include(x => x.Attendees).Include(x => x.RestrictDates).Include(x => x.SuggestedDates).Include(x => x.Attendee).ToList().FirstOrDefault(x => x.Id == id);
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

        public void CreateTeam(Team team)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                team.Id = Guid.NewGuid().ToString();
                ctx.Teams.Add(team);
                ctx.SaveChanges();
            }
        }

        public List<Team> GetTeamsByEventId(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                return ctx.Teams.Include(x=>x.Attendees).ThenInclude(x=>x.Attendee).ThenInclude(x=>x.AvatarSettings).Where(x => x.EventId == id).ToList();
            }
        }


        public List<Attendee> GetAttendeesWithoutTeams(string eventId)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
              return ctx.Attendees.Include(x=>x.AvatarSettings).Where(x => !(ctx.TeamAttendees.Any(y => y.EventId == eventId && x.Id == y.AttendeeId))).ToList();
            }
        }

        public void AddAttendeeToTeam(string eventId,string teamId,string attendeeId)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                ctx.TeamAttendees.Add(new TeamAttendee { Id = Guid.NewGuid().ToString(), EventId = eventId, TeamId = teamId, AttendeeId = attendeeId });
                ctx.SaveChanges();
            }
        }

        public void RemoveAttendeeFromTeam(string eventId, string teamId, string attendeeId)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                TeamAttendee ta = ctx.TeamAttendees.FirstOrDefault(x => x.EventId == eventId && x.TeamId == teamId && x.AttendeeId == attendeeId);
                ctx.TeamAttendees.Remove(ta);
                ctx.SaveChanges();
            }
        }

        public List<Event> GetYourEvents(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                return ctx.Events.Where(x => x.AttendeeId == id).ToList();         
            }
        }

        public List<Event> GetUpComingEvents()
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                return ctx.Events.Include(x=>x.Attendee).ThenInclude(x=>x.AvatarSettings).Include(x=>x.Attendees).Where(x => x.DateAndTime >= DateTime.Today).ToList();
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

        public void DeleteRestrictDate(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                RestrictDate rd = ctx.RestrictDates.Include(x=> x.TimesAlloweds).FirstOrDefault(x => x.Id == id);
                if(rd != null)
                {
                    ctx.RestrictDates.Remove(rd);
                    ctx.SaveChanges();
                }
             
            }
        }

        public void DeleteTimeAllowed(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {       
                TimesAllowed t = ctx.TimesAlloweds.FirstOrDefault(x => x.Id == id);
                if(t != null)
                {
                    ctx.TimesAlloweds.Remove(t);
                    ctx.SaveChanges();
                }
              
            }
        }

        public List<Attendee> GetAvailableUsers(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                SuggestedDate sd = ctx.SuggestedDates.Include(x => x.Attendees).ThenInclude(x=>x.Attendee).ThenInclude(x=>x.AvatarSettings).FirstOrDefault(x=> x.Id == id);
                return sd.Attendees.Select(x => x.Attendee).ToList();
            }
        }

        public Event GetEventById(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                return ctx.Events.Include(x => x.SuggestedDates).Include(x => x.RestrictDates).Include(x => x.Attendee).ThenInclude(x=>x.AvatarSettings).Include(x => x.Attendees).ThenInclude(x => x.Attendee).FirstOrDefault(x => x.Id == id);
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

        public RestrictDate GetRestrictDateById(string id)
        {
            using (var ctx = _dbContextFactory.CreateDbContext())
            {
                try
                {
                    RestrictDate rd = ctx.RestrictDates.Include(x => x.TimesAlloweds).FirstOrDefault(x => x.Id == id);
                    return rd;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}