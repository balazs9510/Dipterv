using AutoMapper;
using BLL.SearchParamters;
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


namespace PublicWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService _service;
        public EventController(IEventService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> GetEvents(EventSearchParameter searchParameter)
        {
            var result = new JsonResult<List<EventDTO>>();
            try
            {
                result.Result = (await _service.GetEventsAsync(searchParameter)).Select(x => Mapper.Map<Event, EventDTO>(x)).ToList();
                result.Success = true;
            }
            catch
            {
                result.Message = "Váratlan hiba az események letöltése során.";
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEvent(Guid id)
        {
            var result = new JsonResult<EventDTO>();
            try
            {
                var xevent = await _service.GetEventAsync(id);
                result.Result = Mapper.Map<Event, EventDTO>(xevent);
                result.Success = true;
            }
            catch
            {
                result.Message = "Váratlan hiba az esemény betöltése során.";
            }
            return Ok(result);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetEventImage(Guid eventId)
        {
            try
            {
                var memoryStream = new MemoryStream(_service.GetEventImage(eventId));
                return File(memoryStream, "image/jpeg");
            }
            catch
            {
                // log
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetTopFive()
        {
            var result = new JsonResult<List<EventDTO>>();
            try
            {
                result.Result = (await _service.GetTopAsync(5)).Select(x => Mapper.Map<Event, EventDTO>(x)).ToList();
                result.Success = true;
            }
            catch
            {
                result.Message = "Váratlan hiba az események letöltése során.";
            }
            return Ok(result);
        }
    }
}