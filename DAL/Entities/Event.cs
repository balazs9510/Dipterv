using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Event
    {
        public Guid Id { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public string EventImage { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        [Required]
        public string UserId { get; set; }
        public User User { get; set; }
        public List<ServiceEvent> ServiceEvents { get; set; }
        public List<EvenSchedule> EvenSchedules { get; set; }
    }
}