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
        /// <summary>
        /// Get list of event for search paramters.
        /// </summary>
        /// <param name="searchParameter">Search parameters.</param>
        /// <returns>Event list.</returns>
        Task<List<Event>> GetEventsAsync(EventSearchParameter searchParameter);

        /// <summary>
        /// Get the image of the event.
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        byte[] GetEventImage(Guid eventId);


        Task<List<Event>> GetTopAsync(int take);

        Task<Event> GetEventAsync(Guid id);
    }
}
