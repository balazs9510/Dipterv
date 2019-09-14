using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWeb.ViewModels
{
    public class ServicePlaceViewModel
    {
        [Required]
        [StringLength(200)]
        [Display(Name = "Név")]
        public string Name { get; set; }

        [Display(Name = "Szolgáltatás")]
        public Guid? ServiceId { get; set; }

        public string UserId { get; set; }

        [Display(Name = "Kép")]
        public IFormFile LayoutImage { get; set; }

        public string ServiceName { get; set; }
        public string ImageSVG { get; set; }

    }
}
