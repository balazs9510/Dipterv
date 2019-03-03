using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWeb.DTOs
{
    public class PendingBookingDTO
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Guid EventScheduleId { get; set; }
        public List<ServicePlacePositionDTO> Positions { get; set; }
        public PendingBooking ToEntity(PendingBooking entity = null)
        {
            if (entity == null) entity = new PendingBooking();
            entity.Date = Date;
            entity.ExpirationDate = ExpirationDate;
            entity.EvenScheduleId = EventScheduleId;
            return entity;
        }
    }
}
