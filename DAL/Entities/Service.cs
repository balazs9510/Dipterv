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
        [Display(Name = "Leírás")]
        public string Description { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Név")]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Város")]
        public string City { get; set; }

        [Required]
        [StringLength(300)]
        [Display(Name = "Utca")]
        public string Street { get; set; }      
        
        [Required]
        public Guid TypeId { get; set; }

        [Display(Name = "Típus")]
        public ServiceType Type { get; set; }

        public Guid? ImageId { get; set; }

        public Image Image { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public ICollection<ServicePlace> Places { get; set; }
        public ICollection<ServiceEvent> ServiceEvents { get; set; }
        public ICollection<EvenSchedule> EvenSchedules { get; set; }
    }
}
