using DAL;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWeb.Controllers
{
    public class BaseController : Controller
    {
        protected readonly BookingSystemDbContext _context;
        protected readonly UserManager<User> _userManager;

        public BaseController(BookingSystemDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        protected async Task<User> GetCurrentUser()
        {
            return await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
        }
        protected string GetCurrentUserId()
        {
            var user = GetCurrentUser().Result;
            return user.Id;
        }
    }
}
