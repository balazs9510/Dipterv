using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Event
    {
        public Guid Id { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public byte[] EventImage { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        [Required]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}