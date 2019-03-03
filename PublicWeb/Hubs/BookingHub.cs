using Microsoft.AspNetCore.SignalR;
using PublicWeb.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWeb.Hubs
{
    public class BookingHub : Hub<IBookingHub>
    {
        public async Task SendPendingBooking(PendingBookingDTO pendingBooking)
        {
            await Clients.All.RecieveNewPendingBooking(pendingBooking);
        }
        public async Task SendBooking(BookingDTO booking)
        {
            await Clients.All.RecieveNewBooking(booking);
        }
    }
}
