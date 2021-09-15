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

        public List<Event> GetYourEvents(string id)
        {

            using (var ctx = _dbContextFactory.CreateDbContext())
            {

                return _appDBContext.Events.Where(x => x.IdentityUserId == id).ToList();
          
            }

        }
    }
}