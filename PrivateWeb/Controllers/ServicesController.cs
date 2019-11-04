using AutoMapper;
using DAL;
using DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class ServicesController : BaseController
    {
        private readonly ILogger _logger;

        public ServicesController(BookingSystemDbContext context, UserManager<User> userManager, ILogger<ServicesController> logger)
            : base(context, userManager)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var bookingSystemDbContext = _context
                    .Services
                    .Include(s => s.Type)
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

        public IActionResult Create()
        {
            try
            {
                ViewData["TypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name");
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
        public async Task<IActionResult> Create(ServiceViewModel serviceViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var service = Mapper.Map<ServiceViewModel, Service>(serviceViewModel);
                    service.Id = Guid.NewGuid();
                    service.UserId = GetCurrentUserId();
                    if (serviceViewModel.Image != null)
                    {
                        var image = new Image
                        {
                            Id = Guid.NewGuid(),
                            Extension = System.IO.Path.GetExtension(serviceViewModel.Image.FileName),
                            Name = serviceViewModel.Image.FileName
                        };
                        using (var memoryStream = new MemoryStream())
                        {
                            await serviceViewModel.Image.CopyToAsync(memoryStream);
                            image.Content = memoryStream.ToArray();
                        }
                        service.ImageId = image.Id;
                        _context.Add(image);
                    }
                    _context.Add(service);

                    await _context.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message, CommonC.ErrorCreate);
                    TempData["ErrorMessage"] = CommonC.ErrorCreate;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(serviceViewModel);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var serviceViewModel = new ServiceViewModel();
            try
            {
                var service = await _context.Services.FindAsync(id);
                serviceViewModel = Mapper.Map<Service, ServiceViewModel>(service);
                if (service == null)
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorEdit);
                TempData["ErrorMessage"] = CommonC.ErrorEdit;
            }
            try
            {
                ViewData["TypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", serviceViewModel.TypeId);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorLoad);
                TempData["ErrorMessage"] = CommonC.ErrorLoad;
            }

            return View(serviceViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ServiceViewModel serviceViewModel)
        {
            if (id != serviceViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var service = await _context.Services
                       .FirstOrDefaultAsync(m => m.Id == id);
                    service = Mapper.Map(serviceViewModel, service);
                    _context.Update(service);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceExists(serviceViewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["TypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", serviceViewModel.TypeId);
            return View(serviceViewModel);
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            try
            {
                var service = await _context.Services
                    .Include(x => x.Image)
                    .Include(x => x.Type)
                    .Include(x => x.ServiceEvents)
                        .ThenInclude(x => x.Event)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (service == null)
                {
                    return NotFound();
                }
                return View(service);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorLoad);
                TempData["ErrorMessage"] = CommonC.ErrorLoad;
            }
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var service = new Service();
            try
            {
                service = await _context.Services
                .Include(s => s.Image)
                .Include(s => s.Type)
                .FirstOrDefaultAsync(m => m.Id == id);
                if (service == null)
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorLoad);
                TempData["ErrorMessage"] = CommonC.ErrorLoad;
            }
            return View(service);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            try
            {
                var service = await _context.Services.FindAsync(id);
                _context.Services.Remove(service);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorDelete);
                TempData["ErrorMessage"] = CommonC.ErrorDelete;
            }
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceExists(Guid id)
        {
            return _context.Services.Any(e => e.Id == id);
        }
    }
}
