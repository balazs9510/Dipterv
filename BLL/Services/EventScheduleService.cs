using BLL.Models;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EventScheduleService : IEventScheduleService
    {
        private readonly BookingSystemDbContext _ctx;
        public EventScheduleService(BookingSystemDbContext context)
        {
            _ctx = context;
        }
        public EvenSchedule GetEvenSchedule(Guid id)
        {
            return _ctx.EvenSchedules
                .Include(x => x.PendingBookings)
                    .ThenInclude(x => x.PendingBookingPositions)
                        .ThenInclude(x => x.ServicePlacePosition)
                .Include(x => x.Bookings)
                    .ThenInclude(x => x.BookingPositions)
                                .ThenInclude(x => x.ServicePlacePosition)
                .Include(x => x.ServicePlace)
                    .ThenInclude(x => x.Layout)
                .FirstOrDefault(x => x.Id == id);
        }

        public async Task<EvenSchedule> GetEvenScheduleAsync(Guid? id)
        {
            // todo remove
            if (!id.HasValue)
                return await _ctx.EvenSchedules
                    .Include(x => x.ServicePlace)
                        .ThenInclude(x => x.LayoutImage)
                    .Include(x => x.ServicePlace)
                        .ThenInclude(x => x.Layout)
                    .Include(x => x.PendingBookings)
                        .ThenInclude(x => x.PendingBookingPositions)
                            .ThenInclude(x => x.ServicePlacePosition)
                    .Include(x => x.Bookings)
                        .ThenInclude(x => x.BookingPositions)
                                .ThenInclude(x => x.ServicePlacePosition)
                      .FirstOrDefaultAsync();
            return await _ctx.EvenSchedules
                .Include(x => x.ServicePlace)
                        .ThenInclude(x => x.LayoutImage)
                .Include(x => x.ServicePlace)
                        .ThenInclude(x => x.Layout)
                .Include(x => x.PendingBookings)
                    .ThenInclude(x => x.PendingBookingPositions)
                        .ThenInclude(x => x.ServicePlacePosition)
                .Include(x => x.Bookings)
                    .ThenInclude(x => x.BookingPositions)
                            .ThenInclude(x => x.ServicePlacePosition)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<EventScheduleDateGroup>> GetEventSchedulesGroupByDate(Guid eventId, Guid serviceId)
        {
            return await _ctx.EvenSchedules
                .Where(x => x.EventId == eventId && x.ServiceId == serviceId)
                .GroupBy(x => x.From.Date)
                .Select(x => new EventScheduleDateGroup { Date = x.Key, EventSchedules = x.ToList() }).ToListAsync();
        }
    }
}
