using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DAL;
using DAL.Entities;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using PrivateWeb.ViewModels;
using PrivateWeb.Resources.Controllers;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using DAL.Users;

namespace PrivateWeb.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class ServiceEventsController : BaseController
    {
        private readonly ILogger _logger;

        public ServiceEventsController(BookingSystemDbContext context, UserManager<User> userManager, ILogger<ServiceEventsController> logger)
            : base(context, userManager)
        {
            _logger = logger;
        }

        public IActionResult Create(Guid serviceId)
        {
            ViewData["EventId"] = new SelectList(
                _context.Events.Where(x => x.UserId == GetCurrentUserId() && !x.ServiceEvents.Any(y => y.ServiceId == serviceId))
                , "Id", "Name");
            var viewModel = new ServiceEventViewModel() { ServiceId = serviceId };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ServiceEventViewModel serviceEventViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var serviceEvent = Mapper.Map<ServiceEventViewModel, ServiceEvent>(serviceEventViewModel);
                    _context.Add(serviceEvent);
                    await _context.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message, CommonC.ErrorCreate);
                    TempData["ErrorMessage"] = CommonC.ErrorCreate;
                }
                return RedirectToAction("Details", "Services", new { @id = serviceEventViewModel.ServiceId});
            }
            try
            {
                ViewData["EventId"] = new SelectList(
                    _context.Events.Where(x => x.UserId == GetCurrentUserId() && !x.ServiceEvents.Any(y => y.ServiceId == serviceEventViewModel.ServiceId)), 
                    "Id", "Name", serviceEventViewModel.EventId);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorLoad);
                TempData["ErrorMessage"] = CommonC.ErrorLoad;
            }
            return View(serviceEventViewModel);
        }

        public async Task<IActionResult> Details(Guid? serviceId, Guid? eventId)
        {
            if (serviceId == null || eventId == null)
            {
                return NotFound();
            }
            try
            {
                var serviceEvent = await _context.ServiceEvents
                    .Include(x => x.Event)
                    .FirstOrDefaultAsync(x => x.EventId == eventId.Value && x.ServiceId == serviceId.Value);
                if (serviceEvent == null)
                {
                    return NotFound();
                }
                var vm = new ServiceEventViewModel();
                vm = Mapper.Map(serviceEvent, vm);
                vm.EvenSchedule = await _context.EvenSchedules
                    .Include(x => x.ServicePlace)
                    .Where(x => x.EventId == vm.EventId && x.ServiceId == vm.ServiceId && x.UserId == GetCurrentUserId()).ToListAsync();
                return View(vm);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorLoad);
                TempData["ErrorMessage"] = CommonC.ErrorLoad;
            }
            return RedirectToAction("Details", "Services", new { @id = serviceId });
        }
        public async Task<IActionResult> Delete(Guid serviceId, Guid eventId)
        {
            try
            {
                var serviceEvent = await _context.ServiceEvents.FirstOrDefaultAsync(x => x.ServiceId == serviceId && x.EventId == eventId);
                _context.ServiceEvents.Remove(serviceEvent);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorDelete);
                TempData["ErrorMessage"] = CommonC.ErrorDelete;
            }
            return RedirectToAction("Details", "Services", new { @id = serviceId });
        }

        private bool ServiceEventExists(Guid id)
        {
            return _context.ServiceEvents.Any(e => e.EventId == id);
        }
    }
}
