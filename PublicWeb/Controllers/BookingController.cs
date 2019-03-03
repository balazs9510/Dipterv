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
            }).CreateMapper();
        }
        [HttpGet]
        public IActionResult Get() => Ok("nem megy ez a szar");
   
        [HttpPost]
        [Route("[action]")]
        public virtual async Task<IActionResult> CreatePendingBooking([FromBody]PendingBookingDTO pendingBooking)
        {
            var result = new JsonResultBase();
            try
            {
                var entity = pendingBooking.ToEntity();
                entity.Id = Guid.NewGuid();
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
            }
            catch (PendingBookingException)
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