using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class BookingPosition
    {
        public string BookingId { get; set; }
        public Booking Booking { get; set; }
        public Guid ServicePlacePositionId { get; set; }
        public ServicePlacePosition ServicePlacePosition { get; set; }
    }
}
