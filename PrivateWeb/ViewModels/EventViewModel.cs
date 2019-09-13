using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWeb.ViewModels
{
    public class EventViewModel
    {
        public Guid Id { get; set; }
        [StringLength(500)]
        [Display(Name = "Részletek")]
        public string Description { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Név")]
        public string Name { get; set; }

        [Display(Name = "Kép")]
        public IFormFile Image { get; set; }

        public string UserId { get; set; }
    }
}
