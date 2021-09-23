using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BlazorMeetup.Data
{
    public class CreateUsers
    {
        private readonly UserManager<Attendee> _userManager;
        public CreateUsers(UserManager<Attendee> userManager)
        {
            _userManager = userManager;
        }
        public async void InitializeUsers()
        {
            for(var i = 1;i<11;i++)
            {
                await _userManager.CreateAsync(new Attendee { Email = "test" + i.ToString() + "@gmail.com", UserName = "test" + i.ToString() + "@gmail.com" }, "test");
            }
        }
    }
}
