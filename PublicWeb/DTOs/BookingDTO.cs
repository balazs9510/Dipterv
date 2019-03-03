using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWeb.DTOs
{
    public class BookingDTO
    {
        public Guid? Id { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public Guid ScheduleId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        public List<ServicePlacePositionDTO> Positions { get; set; }
    }
}
