using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

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

        public async Task<EvenSchedule> GetEvenScheduleAsync(Guid id)
        {
            return await _ctx.EvenSchedules
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
    }
}
