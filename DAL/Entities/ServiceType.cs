using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class ServiceType
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public Guid? ImageId { get; set; }
        public Image Image { get; set; }
        public ICollection<Service> Services { get; set; }
    }
}
