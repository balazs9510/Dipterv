using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class Service
    {
        public Guid Id { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        [Required]
        [StringLength(250)]
        public string City { get; set; }
        [Required]
        [StringLength(300)]
        public string Street { get; set; }
        
        [Required]
        public Guid TypeId { get; set; }
        public ServiceType Type { get; set; }
        public Guid? ImageId { get; set; }
        public Image Image { get; set; }
        public ICollection<ServicePlace> Places { get; set; }
        public ICollection<ServiceEvent> ServiceEvents { get; set; }
        public ICollection<EvenSchedule> EvenSchedules { get; set; }
    }
}
