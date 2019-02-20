using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class EvenSchedule
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; }
        [Required]
        public Guid EventId { get; set; }
        public Event Event { get; set; }
        [Required]
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }
        [Required]
        public Guid ServicePlaceId { get; set; }
        public ServicePlace ServicePlace { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
