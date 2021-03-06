﻿using AutoMapper;
using BLL.Exceptions;
using BLL.Services;
using DAL.Entities;
using EASendMail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using PublicWeb.DTOs;
using PublicWeb.DTOs.JSON;
using PublicWeb.Hubs;
using shortid;
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
        private const string CHARACTERS = "qwertzuiopasdfghjkklyxcvbnm0123456789";
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
                                       y => new BookingPosition { BookingId = src.Id, ServicePlacePositionId = y.Id })));
            }).CreateMapper();
            
        }

        [HttpPost]
        [Route("[action]")]
        public virtual async Task<IActionResult> CreatePendingBooking([FromBody]PendingBookingDTO pendingBooking)
        {
            var result = new JsonResult<PendingBookingDTO>();
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
                var dto = _mapper.Map<PendingBooking, PendingBookingDTO>(entity);
                await _hubContext.Clients.All.RecieveNewPendingBooking(dto);
                result.Success = true;
                result.Result = dto;
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
            var result = new JsonResult<string>();
            try
            {
                ShortId.SetCharacters(CHARACTERS);
                var pendingBooking = await _service.GetPendingBookingByClientIdAsync(booking.PendingBookingId);
                var entity = new Booking
                {
                    Id = ShortId.Generate(true, false, 8).ToUpper(),
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
                result.Result = entity.Id;
                SmtpMail oMail = new SmtpMail("TryIt");
                SmtpClient oSmtp = new SmtpClient();
                oMail.From = "95berta.balazs@gmail.com";
                oMail.To = booking.Email;
                oMail.Subject = "Sikeres foglalás";
                oMail.TextBody = $"Köszönjük a foglalásod. Az azonosító: {entity.Id}.";
                SmtpServer oServer = new SmtpServer("smtp.gmail.com");
                oServer.Port = 587;
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;
                oServer.User = "95berta.balazs@gmail.com";
                oServer.Password = "";
                oSmtp.SendMail(oServer, oMail);
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