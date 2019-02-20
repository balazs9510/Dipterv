using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public Guid PositionId { get; set; }
        public ServicePlacePosition Position { get; set; }
        [Required]
        public Guid ScheduleId { get; set; }
        public EvenSchedule Schedule { get; set; }
        [Required]
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
