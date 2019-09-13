using DAL;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        //protected void AddModelErrors()
        //{
        //    var errorStringBuilder = new StringBuilder();
        //    if (!ModelState.IsValid)
        //    {
        //        foreach (var value in ModelState.Values)
        //        {
        //            foreach (var error in value.Errors)
        //            {
        //                errorStringBuilder.AppendLine(error.ErrorMessage);
        //            }
        //        }
        //        ModelState.AddModelError("error", errorStringBuilder.ToString());
        //    }
        //}
    }
}
