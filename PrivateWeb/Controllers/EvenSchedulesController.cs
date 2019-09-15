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
using PrivateWeb.Resources.Controllers;

namespace PrivateWeb.Controllers
{
    public class EvenSchedulesController : BaseController
    {
        private readonly ILogger _logger;

        public EvenSchedulesController(BookingSystemDbContext context, UserManager<User> userManager, ILogger<EvenSchedulesController> logger)
            : base(context, userManager)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var bookingSystemDbContext =
                       _context.EvenSchedules
                       .Include(e => e.Event)
                       .Include(e => e.Service)
                       .Include(e => e.ServicePlace)
                       .Where(x => x.UserId == GetCurrentUserId());
                return View(await bookingSystemDbContext.ToListAsync());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorLoad);
                TempData["ErrorMessage"] = CommonC.ErrorLoad;
            }
            return View();
        }

        public IActionResult Create(Guid? serviceId, Guid? eventId)
        {
            try
            {
                var userId = GetCurrentUserId();
                ViewData["EventId"] = new SelectList(_context.Events.Where(x => x.UserId == userId), "Id", "Name", eventId);
                ViewData["ServiceId"] = new SelectList(_context.Services.Where(x => x.UserId == userId), "Id", "Name", serviceId);
                ViewData["ServicePlaceId"] = new SelectList(_context.ServicePlaces.Where(x => x.UserId == userId), "Id", "Name");
                if (serviceId.HasValue && eventId.HasValue)
                {
                    ViewData["SelectedEventId"] = eventId.Value;
                    ViewData["SelectedServiceId"] = serviceId.Value;
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorLoad);
                TempData["ErrorMessage"] = CommonC.ErrorLoad;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EvenSchedule evenSchedule)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    evenSchedule.Id = Guid.NewGuid();
                    var serviceEvent = _context.ServiceEvents.FirstOrDefaultAsync(x => x.EventId == evenSchedule.EventId && x.ServiceId == evenSchedule.ServiceId);
                    if (serviceEvent == null)
                    {
                        ModelState.AddModelError("", "A kiválasztott esemény nincs a megadott szolgáltatásban.");
                        ViewData["EventId"] = new SelectList(_context.Events.Where(x => x.UserId == CurrentUserId), "Id", "Name", evenSchedule.EventId);
                        ViewData["ServiceId"] = new SelectList(_context.Services.Where(x => x.UserId == CurrentUserId), "Id", "City", evenSchedule.ServiceId);
                        ViewData["ServicePlaceId"] = new SelectList(_context.ServicePlaces.Where(x => x.UserId == CurrentUserId), "Id", "Name", evenSchedule.ServicePlaceId);
                        return View(evenSchedule);
                    }
                    evenSchedule.UserId = GetCurrentUserId();
                    _context.Add(evenSchedule);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message, CommonC.ErrorCreate);
                    TempData["ErrorMessage"] = CommonC.ErrorCreate;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events.Where(x => x.UserId == CurrentUserId), "Id", "Name", evenSchedule.EventId);
            ViewData["ServiceId"] = new SelectList(_context.Services.Where(x => x.UserId == CurrentUserId), "Id", "City", evenSchedule.ServiceId);
            ViewData["ServicePlaceId"] = new SelectList(_context.ServicePlaces.Where(x => x.UserId == CurrentUserId), "Id", "Name", evenSchedule.ServicePlaceId);
            return View(evenSchedule);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                var evenSchedule = await _context.EvenSchedules.FindAsync(id);
                if (evenSchedule == null)
                {
                    return NotFound();
                }
                ViewData["EventId"] = new SelectList(_context.Events.Where(x => x.UserId == CurrentUserId), "Id", "Name", evenSchedule.EventId);
                ViewData["ServiceId"] = new SelectList(_context.Services.Where(x => x.UserId == CurrentUserId), "Id", "City", evenSchedule.ServiceId);
                ViewData["ServicePlaceId"] = new SelectList(_context.ServicePlaces.Where(x => x.UserId == CurrentUserId), "Id", "Name", evenSchedule.ServicePlaceId);
                return View(evenSchedule);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorLoad);
                TempData["ErrorMessage"] = CommonC.ErrorLoad;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, EvenSchedule evenSchedule)
        {
            if (id != evenSchedule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var serviceEvent = _context.ServiceEvents.FirstOrDefaultAsync(x => x.EventId == evenSchedule.EventId && x.ServiceId == evenSchedule.ServiceId);
                    if (serviceEvent == null)
                    {
                        ModelState.AddModelError("", "A kiválasztott esemény nincs a megadott szolgáltatásban.");
                        ViewData["EventId"] = new SelectList(_context.Events.Where(x => x.UserId == CurrentUserId), "Id", "Name", evenSchedule.EventId);
                        ViewData["ServiceId"] = new SelectList(_context.Services.Where(x => x.UserId == CurrentUserId), "Id", "City", evenSchedule.ServiceId);
                        ViewData["ServicePlaceId"] = new SelectList(_context.ServicePlaces.Where(x => x.UserId == CurrentUserId), "Id", "Name", evenSchedule.ServicePlaceId);
                        return View(evenSchedule);
                    }
                    _context.Update(evenSchedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EvenScheduleExists(evenSchedule.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message, CommonC.ErrorEdit);
                    TempData["ErrorMessage"] = CommonC.ErrorEdit;
                }
                return RedirectToAction(nameof(Index));
            }
            try
            {
                ViewData["EventId"] = new SelectList(_context.Events.Where(x => x.UserId == CurrentUserId), "Id", "Name", evenSchedule.EventId);
                ViewData["ServiceId"] = new SelectList(_context.Services.Where(x => x.UserId == CurrentUserId), "Id", "Name", evenSchedule.ServiceId);
                ViewData["ServicePlaceId"] = new SelectList(_context.ServicePlaces.Where(x => x.UserId == CurrentUserId), "Id", "Name", evenSchedule.ServicePlaceId);

            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorLoad);
                TempData["ErrorMessage"] = CommonC.ErrorLoad;
            }
            return View(evenSchedule);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var evenSchedule = await _context.EvenSchedules.FindAsync(id);
                _context.EvenSchedules.Remove(evenSchedule);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorDelete);
                TempData["ErrorMessage"] = CommonC.ErrorDelete;
            }
            return RedirectToAction(nameof(Index));
        }

        private bool EvenScheduleExists(Guid id)
        {
            return _context.EvenSchedules.Any(e => e.Id == id);
        }
    }
}
