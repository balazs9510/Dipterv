using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IBookingService
    {
        PendingBooking CreatePendingBooking(PendingBooking pendingBooking);
        Task<PendingBooking> CreatePendingBookingAsync(PendingBooking pendingBooking);
        Booking CreateBooking(Booking booking);
        Task<Booking> CreateBookingAsync(Booking booking);
        Task<PendingBooking> GetPendingBookingByClientIdAsync(Guid id);
    }
}
