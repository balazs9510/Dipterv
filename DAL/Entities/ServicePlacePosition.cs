using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class ServicePlacePosition
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        [Required]
        public Guid ServicePlaceId { get; set; }
        public ServicePlace ServicePlace { get; set; }
    }
}