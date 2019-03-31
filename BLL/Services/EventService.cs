using BLL.SearchParamters;
using DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EventService : IEventService
    {
        private readonly BookingSystemDbContext _ctx;
        public EventService(BookingSystemDbContext context)
        {
            _ctx = context;
        }

        public Task<List<Event>> GetEventsAsync(EventSearchParameter searchParameter)
        {
            IQueryable<Event> q = _ctx.Events;
            //if(searchParameter.ServiceId.HasValue)
            //    q = q.Where(x => x.)
            return null;
        }
    }
}
