using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.SearchParamters;
using BLL.Services;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PublicWeb.DTOs;
using PublicWeb.DTOs.JSON;

namespace PublicWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _service;
        private readonly IMapper _mapper;
        public ServiceController(IServiceService service)
        {
            _service = service;
            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ServiceTypeDTO, ServiceType>();
                cfg.CreateMap<Service, ServiceDTO>();
            }).CreateMapper();
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetServiceTypes()
        {
            var result = new JsonResult<List<ServiceTypeDTO>>();
            try
            {
                result.Result = (await _service.GetServiceTypesAsync()).Select(x => _mapper.Map<ServiceType, ServiceTypeDTO>(x)).ToList();
                result.Success = true;
            }
            catch
            {
                result.Message = "Ismeretlen hiba a szolgáltatás típusok letöltése során.";
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> GetServices(ServiceSearchParameter searchParameter)
        {
            var result = new JsonResult<List<ServiceDTO>>();
            try
            {
                result.Result = (await _service.GetServicesAsync(searchParameter)).Select(x => _mapper.Map<Service, ServiceDTO>(x)).ToList();
                result.Success = true;
            }
            catch
            {
                result.Message = "Ismeretlen hiba a szolgáltatások letöltése során.";
            }
            return Ok(result);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetServiceOfEvent(Guid eventId)
        {
            var result = new JsonResult<List<ServiceDTO>>();
            try
            {
                result.Result = (await _service.GetServiceOfEventAsync(eventId)).Select(x => _mapper.Map<Service, ServiceDTO>(x)).ToList();
                result.Success = true;
            }
            catch
            {
                result.Message = "Ismeretlen hiba az eseményekhez tartozó szolgáltatások letöltése során.";
            }
            return Ok(result);
        }
    }
}