using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DAL;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using PrivateWeb.Resources.Controllers;
using PrivateWeb.ViewModels;
using AutoMapper;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using System.Text;

namespace PrivateWeb.Controllers
{
    public class ServicePlacesController : BaseController
    {
        private const string DATA_NAME = "data-name";
        private const string BOOKABLE = "bookable";
        private const string DATA_POSITION_ID = "data-position-id";

        private readonly ILogger _logger;

        public ServicePlacesController(BookingSystemDbContext context, UserManager<User> userManager, ILogger<ServicePlacesController> logger)
            : base(context, userManager)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var bookingSystemDbContext = _context.ServicePlaces
                    .Include(s => s.LayoutImage)
                    .Include(s => s.Service)
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
                ViewData["ServiceId"] = new SelectList(_context.Services.Where(x => x.UserId == GetCurrentUserId()), "Id", "Name");

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
        public async Task<IActionResult> Create(ServicePlaceViewModel servicePlaceViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var servicePlace = Mapper.Map<ServicePlaceViewModel, ServicePlace>(servicePlaceViewModel);
                    servicePlace.Id = Guid.NewGuid();
                    servicePlace.UserId = GetCurrentUserId();

                    if (servicePlaceViewModel.LayoutImage == null || !Path.GetExtension(servicePlaceViewModel.LayoutImage.FileName).Equals(".svg"))
                    {
                        ViewData["ServiceId"] = new SelectList(_context.Services.Where(x => x.UserId == GetCurrentUserId()), "Id", "Name", servicePlaceViewModel.ServiceId);
                        ModelState.AddModelError(nameof(servicePlaceViewModel.LayoutImage), "Nem megfelelő képet töltött fel!");
                        return View();
                    }

                    var image = new Image
                    {
                        Id = Guid.NewGuid(),
                        Extension = System.IO.Path.GetExtension(servicePlaceViewModel.LayoutImage.FileName),
                        Name = servicePlaceViewModel.LayoutImage.FileName
                    };
                    servicePlace.LayoutImageId = image.Id;

                    using (var transaction = _context.Database.BeginTransaction())
                    {
                        _context.Add(image);
                        image.Content = ProcessLayoutImage(servicePlaceViewModel.LayoutImage.OpenReadStream(), servicePlace.Id);
                        _context.Add(servicePlace);
                        await _context.SaveChangesAsync();

                        transaction.Commit();
                    }

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message, CommonC.ErrorCreate);
                    TempData["ErrorMessage"] = CommonC.ErrorCreate;
                }
            }
            return View(servicePlaceViewModel);
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            try
            {
                var servicePlaceViewModel = new ServicePlaceViewModel();
                var servicePlace = await _context.ServicePlaces
                    .Include(s => s.LayoutImage)
                    .Include(s => s.Service)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(m => m.Id == id);
                servicePlaceViewModel = Mapper.Map(servicePlace, servicePlaceViewModel);
                servicePlaceViewModel.ImageSVG = Encoding.UTF8.GetString(servicePlace.LayoutImage.Content, 0, servicePlace.LayoutImage.Content.Length);
                if (servicePlace == null)
                {
                    return NotFound();
                }
                return View(servicePlaceViewModel);
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
            try
            {

                var servicePlace = await _context.ServicePlaces
                    .Include(s => s.Service)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (servicePlace == null)
                {
                    return NotFound();
                }
                return View(servicePlace);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorLoad);
                TempData["ErrorMessage"] = CommonC.ErrorLoad;
            }
            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            try
            {
                var servicePlace = await _context.ServicePlaces.FindAsync(id);
                _context.ServicePlaces.Remove(servicePlace);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, CommonC.ErrorDelete);
                TempData["ErrorMessage"] = CommonC.ErrorDelete;
            }
            return RedirectToAction("Index");
        }

        private bool ServicePlaceExists(Guid id)
        {
            return _context.ServicePlaces.Any(e => e.Id == id);
        }

        private byte[] ProcessLayoutImage(Stream imageStream, Guid servicePlaceId)
        {
            var xdoc = XDocument.Load(imageStream);
            var bookablePositions = xdoc
                .Descendants()
                .Where(x => x
                    .Attributes()
                    .Any(y => y.Name.LocalName.Equals("class") 
                              && y.Value.Contains(BOOKABLE)));
            foreach (var bookablePosition in bookablePositions)
            {
                var layoutPosition = new ServicePlacePosition
                {
                    Id = Guid.NewGuid(),
                    Name = bookablePosition.Attribute(DATA_NAME).Value,
                    ServicePlaceId = servicePlaceId
                };
                var idAttribute = new XAttribute(DATA_POSITION_ID, layoutPosition.Id.ToString().ToLower());
                bookablePosition.Add(idAttribute);
                _context.Add(layoutPosition);
            }
            var settings = new XmlWriterSettings { OmitXmlDeclaration = true, Encoding = Encoding.UTF8 };
            using (var memoryStream = new MemoryStream())
            using (var xmlWriter = XmlWriter.Create(memoryStream, settings))
            {
                xdoc.WriteTo(xmlWriter);
                xmlWriter.Flush();
                return memoryStream.ToArray();
            }
        }
    }
}
