using AutoMapper;
using BLL.Services;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using PublicWeb.DTOs;
using PublicWeb.DTOs.JSON;
using System;
using System.Linq;
using System.Threading.Tasks;

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
                cfg.CreateMap<ServicePlaceDTO, ServicePlace>();
                cfg.CreateMap<EventScheduleDTO, EvenSchedule>();
                cfg.CreateMap<PendingBooking, PendingBookingDTO>()
                    .ForMember(x => x.Positions, opt => opt.MapFrom(src => src.PendingBookingPositions.Select(y => y.ServicePlacePosition)));
                cfg.CreateMap<Booking, BookingDTO>()
                    .ForMember(x => x.Positions, opt => opt.MapFrom(src => src.BookingPositions.Select(y => y.ServicePlacePosition)));
                cfg.CreateMap<ServicePlacePositionDTO, ServicePlacePosition>();
            }).CreateMapper();
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetEvenSchedule(Guid id)
        {
            var result = new JsonResult<EventScheduleDTO>();
            try
            {
                var eventSchedule = await _service.GetEvenScheduleAsync(id);
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
    }
}