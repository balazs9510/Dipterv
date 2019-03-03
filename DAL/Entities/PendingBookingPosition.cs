using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class PendingBookingPosition
    {
        public Guid PendingBookingId { get; set; }
        public PendingBooking PendingBooking { get; set; }
        public Guid ServicePlacePositionId { get; set; }
        public ServicePlacePosition ServicePlacePosition { get; set; }
    }
}
