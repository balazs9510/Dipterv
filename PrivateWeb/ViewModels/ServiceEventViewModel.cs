using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWeb.ViewModels
{
    public class ServiceEventViewModel
    {
        [Required]
        [Display(Name = "Szolgáltatás")]
        public Guid ServiceId { get; set; }

        [Required]
        [Display(Name = "Esemény")]
        public Guid EventId { get; set; }
    }
}
