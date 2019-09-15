using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWeb.ViewModels
{
    public class EventScheduleViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Időpont kezdete")]
        public DateTime From { get; set; }

        [Display(Name = "Időpont vége")]
        public DateTime? To { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Leírás")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Esemény")]
        public Guid EventId { get; set; }

        [Required]
        [Display(Name = "Szolgáltatás")]
        public Guid ServiceId { get; set; }
        
        [Required]
        [Display(Name = "Helyszín")]
        public Guid ServicePlaceId { get; set; }

        public string UserId { get; set; }
    }
}
