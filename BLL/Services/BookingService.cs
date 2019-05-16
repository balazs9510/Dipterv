using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Exceptions;
using DAL;
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
        public Booking CreateBooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        public async Task<Booking> CreateBookingAsync(Booking booking)
        {
            // TODO pendingekre is
            foreach (var position in booking.BookingPositions)
            {
               if(_context.BookingPositions
                    .Include(x => x.Booking)
                    .Any(x => x.Booking.ScheduleId == booking.ScheduleId
                            && x.ServicePlacePositionId == position.ServicePlacePositionId))
                    throw new BookingException("Already extists booking for that place.");
            }
            _context.BookingPositions.AddRange(booking.BookingPositions);
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
            return await _context.Bookings.Include(x => x.BookingPositions).ThenInclude(x => x.ServicePlacePosition).FirstOrDefaultAsync(x => x.Id == booking.Id);
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
                    throw new BookingException("Already extists booking for that place.");
            }
            _context.PendingBookingPositions.AddRange(pendingBooking.PendingBookingPositions);
            _context.PendingBookings.Add(pendingBooking);
            await _context.SaveChangesAsync();
            return await _context.PendingBookings.Include(x => x.PendingBookingPositions).ThenInclude(x => x.ServicePlacePosition).FirstOrDefaultAsync(x => x.Id == pendingBooking.Id);
        }

        public async Task<PendingBooking> GetPendingBookingByClientIdAsync(Guid id)
        {
            return await _context.PendingBookings
                .Include(x => x.PendingBookingPositions)
                    .ThenInclude(y => y.ServicePlacePosition)
                .FirstOrDefaultAsync(x => x.ClientId == id);
        }
    }
}
