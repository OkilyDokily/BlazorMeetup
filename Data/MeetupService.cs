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

        public bool UserExists(string id)
        {
            bool exists = false;
            using (var ctx = _dbContextFactory.CreateDbContext())
            {

                exists = _appDBContext.Users.Any(x => x.Id == id);

            }

            return exists;
        }
    }
}