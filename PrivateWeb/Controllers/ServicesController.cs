using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DAL;
using DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace PrivateWeb.Controllers
{
    [Authorize]
    public class ServicesController : Controller
    {
        private readonly BookingSystemDbContext _context;
        private readonly UserManager<User> _userManager;

        public ServicesController(BookingSystemDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Services
        public async Task<IActionResult> Index()
        {
            var bookingSystemDbContext = _context.Services.Include(s => s.Image).Include(s => s.Type);
            return View(await bookingSystemDbContext.ToListAsync());
        }

        // GET: Services/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .Include(s => s.Image)
                .Include(s => s.Type)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // GET: Services/Create
        public IActionResult Create()
        {
            ViewData["ImageId"] = new SelectList(_context.Images, "Id", "Id");
            ViewData["TypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name");
            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,Name,City,Street,TypeId,ImageId")] Service service)
        {
            if (ModelState.IsValid)
            {
                service.Id = Guid.NewGuid();
                _context.Add(service);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ImageId"] = new SelectList(_context.Images, "Id", "Id", service.ImageId);
            ViewData["TypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", service.TypeId);
            return View(service);
        }

        // GET: Services/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }
            ViewData["ImageId"] = new SelectList(_context.Images, "Id", "Id", service.ImageId);
            ViewData["TypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", service.TypeId);
            return View(service);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Description,Name,City,Street,TypeId,ImageId")] Service service)
        {
            if (id != service.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(service);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceExists(service.Id))
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
            ViewData["ImageId"] = new SelectList(_context.Images, "Id", "Id", service.ImageId);
            ViewData["TypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", service.TypeId);
            return View(service);
        }

        // GET: Services/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .Include(s => s.Image)
                .Include(s => s.Type)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var service = await _context.Services.FindAsync(id);
            _context.Services.Remove(service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceExists(Guid id)
        {
            return _context.Services.Any(e => e.Id == id);
        }
    }
}
