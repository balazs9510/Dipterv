using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class PendingBooking
    {
        public Guid Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }
        [Required]
        public Guid EvenScheduleId { get; set; }
        public EvenSchedule Schedule { get; set; }
        public Guid ClientId { get; set; }
        public ICollection<PendingBookingPosition> PendingBookingPositions { get; set; }
        [NotMapped]
        public bool Expired
        {
            get
            {
                return ExpirationDate < DateTime.Now;
            }
        }
    }
}
