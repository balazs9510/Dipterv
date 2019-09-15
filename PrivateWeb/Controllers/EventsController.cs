using AutoMapper;
using DAL;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PrivateWeb.Resources.Controllers;
using PrivateWeb.ViewModels;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWeb.Controllers
{
    public class EventsController : BaseController
    {
        private readonly ILogger _logger;

        public EventsController(BookingSystemDbContext context, UserManager<User> userManager, ILogger<EventsController> logger)
            : base(context, userManager)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var bookingSystemDbContext = _context
                    .Events
                    .Where(x => x.UserId == GetCurrentUserId())
                    .OrderBy(x => x.Name);
                return View(await bookingSystemDbContext.ToListAsync());

            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorLoad);
                TempData["ErrorMessage"] = CommonC.ErrorLoad;
            }
            return View();
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            try
            {
                var xevent = await _context.Events
                    .Include(x => x.Image)
                    .Include(x => x.User)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (xevent == null)
                {
                    return NotFound();
                }
                return View(xevent);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorLoad);
                TempData["ErrorMessage"] = CommonC.ErrorLoad;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventViewModel eventViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var xevent = Mapper.Map<EventViewModel, Event>(eventViewModel);
                    xevent.Id = Guid.NewGuid();
                    xevent.UserId = GetCurrentUserId();
                    if (eventViewModel.Image == null)
                    {
                        ModelState.AddModelError("Image", "Kötelező képet feltölteni.");
                        return View(eventViewModel);
                    }
                    var image = new Image
                    {
                        Id = Guid.NewGuid(),
                        Extension = System.IO.Path.GetExtension(eventViewModel.Image.FileName),
                        Name = eventViewModel.Image.FileName
                    };
                    using (var memoryStream = new MemoryStream())
                    {
                        await eventViewModel.Image.CopyToAsync(memoryStream);
                        image.Content = memoryStream.ToArray();
                    }
                    xevent.ImageId = image.Id;
                    _context.Add(image);

                    _context.Add(xevent);
                    await _context.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message, CommonC.ErrorCreate);
                    TempData["ErrorMessage"] = CommonC.ErrorCreate;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(eventViewModel);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var eventViewModel = new EventViewModel();

            try
            {


                var xevent = await _context.Events.FindAsync(id);
                if (xevent == null)
                {
                    return NotFound();
                }
                eventViewModel = Mapper.Map<Event, EventViewModel>(xevent);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorLoad);
                TempData["ErrorMessage"] = CommonC.ErrorLoad;
            }
            return View(eventViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, EventViewModel eventViewModel)
        {
            if (id != eventViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var xevent = await _context.Events
                        .FirstOrDefaultAsync(m => m.Id == id);
                    xevent = Mapper.Map(eventViewModel, xevent);
                    _context.Update(xevent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(eventViewModel.Id))
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
            return View(eventViewModel);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var xevent = new Event();
            try
            {
                xevent = await _context.Events
                        .FirstOrDefaultAsync(m => m.Id == id);
                if (xevent == null)
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorLoad);
                TempData["ErrorMessage"] = CommonC.ErrorLoad;
            }

            return View(xevent);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            try
            {
                var xevent = await _context.Events.FindAsync(id);
                _context.Events.Remove(xevent);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorDelete);
                TempData["ErrorMessage"] = CommonC.ErrorDelete;
            }
            return RedirectToAction(nameof(Index));
        }

        private bool EventExists(Guid id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }
}
