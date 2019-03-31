using BLL.SearchParamters;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Event>> GetEventsAsync(EventSearchParameter searchParameter)
        {
            IQueryable<Event> q = _ctx.Events.Include(x => x.EvenSchedules).Include(x => x.ServiceEvents).ThenInclude(y => y.Event);
            if (searchParameter.ServiceId.HasValue)
                q = q.Where(x => x.ServiceEvents.Any(y => y.ServiceId == searchParameter.ServiceId));
            if (!string.IsNullOrEmpty(searchParameter.Name))
                q = q.Where(x => x.Name.Contains(searchParameter.Name));
            if (searchParameter.BeginDate.HasValue)
                q = q.Where(x => x.EvenSchedules.Any(y => y.From >= searchParameter.BeginDate));
            return await q.ToListAsync();
        }
    }
}
