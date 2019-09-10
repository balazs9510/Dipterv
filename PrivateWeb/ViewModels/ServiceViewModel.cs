using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWeb.ViewModels
{
    public class ServiceViewModel
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public Guid TypeId { get; set; }
        public IFormFile Image { get; set; }
    }
}
