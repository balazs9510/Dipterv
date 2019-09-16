using BLL.SearchParamters;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IEventService
    {
        Task<List<Event>> GetEventsAsync(EventSearchParameter searchParameter);
        byte[] GetEventImage(Guid eventId);
        Task<List<Event>> GetTopAsync(int take);
    }
}
