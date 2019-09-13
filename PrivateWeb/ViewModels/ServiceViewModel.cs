using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWeb.ViewModels
{
    public class ServiceViewModel
    {
        public Guid Id { get; set; }
        [Display(Name = "Leírás")]
        public string Description { get; set; }
        [Display(Name = "Név")]
        public string Name { get; set; }
        [Display(Name = "Város")]
        public string City { get; set; }
        [Display(Name = "Utca")]
        public string Street { get; set; }
        [Display(Name = "Típus")]
        public Guid TypeId { get; set; }
        [Display(Name = "Kép")]
        public IFormFile Image { get; set; }
    }
}
