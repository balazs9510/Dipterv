using Microsoft.AspNetCore.SignalR;
using PublicWeb.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWeb.Hubs
{
    public interface IBookingHub
    {
        Task RecieveNewPendingBooking(PendingBookingDTO pendingBooking);
        Task RecieveNewBooking(BookingDTO booking);
    }
}
