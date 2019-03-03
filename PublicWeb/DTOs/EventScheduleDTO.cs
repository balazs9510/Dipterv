using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWeb.DTOs
{
    public class EventScheduleDTO
    {
        public Guid Id { get; set; }
        public DateTime From { get; set; }
        public DateTime? To { get; set; }
        public string Description { get; set; }
        public ServicePlaceDTO ServicePlace { get; set; }
        public List<PendingBookingDTO> PendingBookings { get; set; }
        public List<BookingDTO> Bookings { get; set; }
    }
}
