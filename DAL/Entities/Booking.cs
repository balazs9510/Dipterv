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
        public Guid LayoutPositionId { get; set; }
        [Required]
        public Guid ScheduleId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        // TODO nav propertyk
    }
}
