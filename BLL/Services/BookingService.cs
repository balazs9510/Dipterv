using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Exceptions;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services
{
    public class BookingService : IBookingService
    {
        private readonly BookingSystemDbContext _context;
        public BookingService(BookingSystemDbContext context)
        {
            _context = context;
        }
        public void CreateBooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        public Task CreateBookingAsync(Booking booking)
        {
            throw new NotImplementedException();
        }

        public PendingBooking CreatePendingBooking(PendingBooking pendingBooking)
        {
            throw new NotImplementedException();
        }

        public async Task<PendingBooking> CreatePendingBookingAsync(PendingBooking pendingBooking)
        {
            // TODO foglalásra is
            foreach (var position in pendingBooking.PendingBookingPositions)
            {
                if (_context.PendingBookingPositions.Include(x => x.PendingBooking)
                    .Any(x => x.PendingBooking.EvenScheduleId == pendingBooking.EvenScheduleId 
                         && x.PendingBooking.ExpirationDate > DateTime.Now
                         && x.ServicePlacePositionId == position.ServicePlacePositionId))
                    throw new PendingBookingException("Already extists booking for that place.");
            }
            _context.PendingBookingPositions.AddRange(pendingBooking.PendingBookingPositions);
            _context.PendingBookings.Add(pendingBooking);
            await _context.SaveChangesAsync();
            return await _context.PendingBookings.Include(x => x.PendingBookingPositions).ThenInclude(x => x.ServicePlacePosition).FirstOrDefaultAsync(x => x.Id == pendingBooking.Id);
        }

        public List<PendingBooking> GetPendingBookingsForEventSchedule(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PendingBooking>> GetPendingBookingsForEventScheduleAsync(Guid id)
        {
            return await _context.PendingBookings
                .Include(x => x.PendingBookingPositions)
                .ThenInclude(y => y.ServicePlacePosition)
                .Where(x => x.EvenScheduleId == id).ToListAsync();
        }
    }
}
