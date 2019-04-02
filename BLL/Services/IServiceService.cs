using BLL.SearchParamters;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IServiceService
    {
        Task<List<ServiceType>> GetServiceTypesAsync();
        Task<List<Service>> GetServicesAsync(ServiceSearchParameter searchParameter);
        Task<List<Service>> GetServiceOfEventAsync(Guid eventId);
    }
}
