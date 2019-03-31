using BLL.SearchParamters;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ServiceService : IServiceService
    {
        private readonly BookingSystemDbContext _ctx;
        public ServiceService(BookingSystemDbContext context)
        {
            _ctx = context;
        }

        public async Task<List<Service>> GetServicesAsync(ServiceSearchParameter searchParameter)
        {
            IQueryable<Service> q = _ctx.Services;
            if (searchParameter.ServiceTypeId.HasValue)
                q = q.Where(x => x.TypeId == searchParameter.ServiceTypeId.Value);
            if (!string.IsNullOrEmpty(searchParameter.Name))
                q = q.Where(x => x.Name.Contains(searchParameter.Name));
            if (!string.IsNullOrEmpty(searchParameter.City))
                q = q.Where(x => x.City.Contains(searchParameter.City));

            return await q.ToListAsync();
        }

        public async Task<List<ServiceType>> GetServiceTypesAsync()
        {
            return await _ctx.ServiceTypes.ToListAsync();
        }
    }
}
