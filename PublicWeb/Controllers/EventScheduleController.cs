using AutoMapper;
using BLL.Models;
using BLL.Services;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using PublicWeb.DTOs;
using PublicWeb.DTOs.JSON;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PublicWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventScheduleController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IEventScheduleService _service;
        private readonly IMapper _mapper;
        public EventScheduleController(IEventScheduleService service, IBookingService bookingService)
        {
            _service = service;
            _bookingService = bookingService;
            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ServicePlaceDTO, ServicePlace>()
                    .ForMember(x => x.LayoutImage, opt => opt.MapFrom(src => string.Empty));
                cfg.CreateMap<EventScheduleDTO, EvenSchedule>();
                cfg.CreateMap<PendingBooking, PendingBookingDTO>()
                    .ForMember(x => x.Positions, opt => opt.MapFrom(src => src.PendingBookingPositions.Select(y => y.ServicePlacePosition)));
                cfg.CreateMap<Booking, BookingDTO>()
                    .ForMember(x => x.Positions, opt => opt.MapFrom(src => src.BookingPositions.Select(y => y.ServicePlacePosition)));
                cfg.CreateMap<EventScheduleDateGroup, EventScheduleDateGroupDTO>();
                cfg.CreateMap<ServicePlacePositionDTO, ServicePlacePosition>();
            }).CreateMapper();
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetEventSchedule(Guid? id)
        {
            var result = new JsonResult<EventScheduleDTO>();
            try
            {
                var eventSchedule = await _service.GetEvenScheduleAsync(id);
                if (eventSchedule == null)
                    return BadRequest();
                var esDto = _mapper.Map<EvenSchedule, EventScheduleDTO>(eventSchedule);
                foreach (var pBooking in esDto.PendingBookings.Where(x => x.ExpirationDate > DateTime.Now))
                {
                    pBooking.Positions = eventSchedule
                        .PendingBookings
                        .FirstOrDefault(x => x.Id == pBooking.Id)
                        .PendingBookingPositions
                        .Select(x => _mapper.Map<ServicePlacePosition, ServicePlacePositionDTO>(x.ServicePlacePosition)).ToList();
                }
                foreach (var booking in esDto.Bookings)
                {
                    booking.Positions = eventSchedule
                        .Bookings
                        .FirstOrDefault(x => x.Id == booking.Id)
                        .BookingPositions
                        .Select(x => _mapper.Map<ServicePlacePosition, ServicePlacePositionDTO>(x.ServicePlacePosition)).ToList();
                }
                esDto.PendingBookings = esDto.PendingBookings.Where(x => x.ExpirationDate > DateTime.Now).ToList();
                esDto.ServicePlace.Layout = esDto.ServicePlace.Layout.OrderBy(x => x.Name).ToList();
                var image = XDocument.Load(new MemoryStream(eventSchedule.ServicePlace.LayoutImage.Content));
                esDto.ServicePlace.LayoutImage = image.Root.ToString();
                result.Result = esDto;
                result.Success = true;
            }
            catch
            {
                // TODO log
                result.Message = "Váratlan hiba az esemény lekérdezése során.";
            }
            return Ok(result);
        }
        [HttpGet]
        public virtual async Task<IActionResult> GetEventSchedule()
        {
            var result = new JsonResult<EventScheduleDTO>();
            try
            {
                var eventSchedule = await _service.GetEvenScheduleAsync(null);
                if (eventSchedule == null)
                    return BadRequest();
                var esDto = _mapper.Map<EvenSchedule, EventScheduleDTO>(eventSchedule);
                foreach (var pBooking in esDto.PendingBookings)
                {
                    pBooking.Positions = eventSchedule
                        .PendingBookings
                        .FirstOrDefault(x => x.Id == pBooking.Id)
                        .PendingBookingPositions
                        .Select(x => _mapper.Map<ServicePlacePosition, ServicePlacePositionDTO>(x.ServicePlacePosition)).ToList();
                }
                foreach (var booking in esDto.Bookings)
                {
                    booking.Positions = eventSchedule
                        .Bookings
                        .FirstOrDefault(x => x.Id == booking.Id)
                        .BookingPositions
                        .Select(x => _mapper.Map<ServicePlacePosition, ServicePlacePositionDTO>(x.ServicePlacePosition)).ToList();
                }
                esDto.ServicePlace.Layout = esDto.ServicePlace.Layout.OrderBy(x => x.Name).ToList();
                result.Result = esDto;
                result.Success = true;
            }
            catch
            {
                // TODO log
                result.Message = "Váratlan hiba az esemény lekérdezése során.";
            }
            return Ok(result);
        }
        [Route("[action]")]
        public virtual async Task<IActionResult> GetEventEventShedules(Guid eventId, Guid serviceId)
        {
            var result = new JsonResult<List<EventScheduleDateGroupDTO>>();
            try
            {
                result.Result = (await _service.GetEventSchedulesGroupByDate(eventId, serviceId)).Select(x => _mapper.Map<EventScheduleDateGroup, EventScheduleDateGroupDTO>(x)).ToList();
                result.Success = true;
            }
            catch
            {
                result.Message = "Váratlan hiba az esemény időpontjainak lekérdezése során.";
            }
            return Ok(result);
        }
    }
}