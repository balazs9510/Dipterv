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
    [Authorize]
    public class ServicesController : BaseController
    {
        private readonly ILogger _logger;

        public ServicesController(BookingSystemDbContext context, UserManager<User> userManager, ILogger<ServicesController> logger)
            : base(context, userManager)
        {
            _logger = logger;
        }

        // GET: Services
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
                ViewBag.ErrorMessage = CommonC.ErrorLoad;
            }
            return View();
        }

        // GET: Services/Create
        public IActionResult Create()
        {
            try
            {
                ViewData["TypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name");
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorLoad);
                ViewBag.ErrorMessage = CommonC.ErrorLoad;
            }

            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
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
                    ViewBag.ErrorMessage = CommonC.ErrorCreate;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(serviceViewModel);
        }

        // GET: Services/Edit/5
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
                ViewBag.ErrorMessage = CommonC.ErrorEdit;
            }
            try
            {
                ViewData["TypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", serviceViewModel.TypeId);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorLoad);
                ViewBag.ErrorMessage = CommonC.ErrorLoad;
            }

            return View(serviceViewModel);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
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
                    var service = Mapper.Map<ServiceViewModel, Service>(serviceViewModel);
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

        // GET: Services/Delete/5
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
                ViewBag.ErrorMessage = CommonC.ErrorLoad;
            }
            return View(service);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
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
                ViewBag.ErrorMessage = CommonC.ErrorDelete;
            }
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceExists(Guid id)
        {
            return _context.Services.Any(e => e.Id == id);
        }
    }
}
