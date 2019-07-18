using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class ServicePlace
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        [Required]
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public Guid? LayoutImageId { get; set; }
        public Image LayoutImage { get; set; }
        public ICollection<ServicePlacePosition> Layout { get; set; }
        public ICollection<EvenSchedule> EvenSchedules { get; set; }
    }
}