using AutoMapper;
using BLL.Exceptions;
using BLL.Services;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using PublicWeb.DTOs;
using PublicWeb.DTOs.JSON;
using PublicWeb.Hubs;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IHubContext<BookingHub, IBookingHub> _hubContext;

        private readonly IBookingService _service;
        private readonly IMapper _mapper;
        public BookingController(IBookingService service, IHubContext<BookingHub, IBookingHub> hubContext)
        {
            _service = service;
            _hubContext = hubContext;
            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PendingBooking, PendingBookingDTO>()
                    .ForMember(x => x.Positions, opt => opt.MapFrom(src => src.PendingBookingPositions.Select(y => y.ServicePlacePosition)));
                cfg.CreateMap<ServicePlacePositionDTO, ServicePlacePosition>();
                cfg.CreateMap<Booking, BookingDTO>()
                    .ForMember(x => x.Positions,
                                opt => opt.MapFrom(src => src.BookingPositions.Select(y => new ServicePlacePositionDTO
                                {
                                    Id = y.ServicePlacePositionId,
                                    Name = y.ServicePlacePosition.Name,
                                    ServicePlaceId = y.ServicePlacePosition.ServicePlaceId
                                })));
                cfg.CreateMap<BookingDTO, Booking>()
                    .ForMember(x => x.BookingPositions,
                               opt => opt.MapFrom(
                                   src => src.Positions.Select(
                                       y => new BookingPosition { BookingId = src.Id.Value, ServicePlacePositionId = y.Id })));
            }).CreateMapper();
        }
        [HttpGet]
        public IActionResult Get() => Ok("nem megy ez a szar");

        [HttpPost]
        [Route("[action]")]
        public virtual async Task<IActionResult> CreatePendingBooking([FromBody]PendingBookingDTO pendingBooking)
        {
            var result = new JsonResult<Guid>();
            try
            {
                var entity = pendingBooking.ToEntity();
                entity.Id = Guid.NewGuid();
                entity.ClientId = Guid.NewGuid();
                entity.Date = DateTime.Now;
                entity.ExpirationDate = DateTime.Now.AddMinutes(2);
                entity.PendingBookingPositions = pendingBooking.Positions.Select(x => new PendingBookingPosition
                {
                    PendingBookingId = entity.Id,
                    ServicePlacePositionId = x.Id
                }).ToList();
                entity = await _service.CreatePendingBookingAsync(entity);
                await _hubContext.Clients.All.RecieveNewPendingBooking(_mapper.Map<PendingBooking, PendingBookingDTO>(entity));
                result.Success = true;
                result.Result = entity.ClientId;
            }
            catch (BookingException)
            {
                result.Message = "Valaki más már tett foglalást a kiválasztott hely(ek)re.";
            }
            catch
            {
                // TODO log
                result.Message = "A foglalási kérelmet nem lehet elindítani váratlan hiba miatt.";
            }
            return Ok(result);
        }
        [HttpPost]
        public virtual async Task<IActionResult> CreateBooking(CreateBookingDTO booking)
        {
            var result = new JsonResultBase();
            try
            {
                var pendingBooking = await _service.GetPendingBookingByClientIdAsync(booking.ClientId);
                var entity = new Booking
                {
                    Id = Guid.NewGuid(),
                    Date = DateTime.Now,
                    Email = booking.Email,
                    Name = booking.Name,
                    Phone = booking.Phone,
                    ScheduleId = pendingBooking.EvenScheduleId
                };
                entity.BookingPositions = pendingBooking
                    .PendingBookingPositions
                    .Select(x => new BookingPosition
                    {
                        BookingId = entity.Id,
                        ServicePlacePositionId = x.ServicePlacePositionId
                    })
                    .ToList();
                entity = await _service.CreateBookingAsync(entity);
                await _hubContext.Clients.All.RecieveNewBooking(_mapper.Map<Booking, BookingDTO>(entity));
                result.Success = true;
            }
            catch (BookingException)
            {
                result.Message = "Valaki más már tett foglalást a kiválasztott hely(ek)re.";
            }
            catch
            {
                // TODO log
                result.Message = "A foglalási kérelmet nem lehet elindítani váratlan hiba miatt.";
            }
            return Ok(result);
        }
    }
}