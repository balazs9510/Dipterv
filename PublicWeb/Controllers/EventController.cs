using AutoMapper;
using BLL.SearchParamters;
using BLL.Services;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using PublicWeb.DTOs;
using PublicWeb.DTOs.JSON;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService _service;
        private readonly IMapper _mapper;
        public EventController(IEventService service)
        {
            _service = service;
            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Event, EventDTO>();
            }).CreateMapper();
        }
        [HttpPost]
        public async Task<IActionResult> GetEvents(EventSearchParameter searchParameter)
        {
            var result = new JsonResult<List<EventDTO>>();
            try
            {
                result.Result = (await _service.GetEventsAsync(searchParameter)).Select(x => _mapper.Map<Event, EventDTO>(x)).ToList();
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