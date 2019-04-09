using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWeb.DTOs
{
    public class EventDTO
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string EventImage { get; set; }
        public string Name { get; set; }
        public ImageDTO Image { get; set; }
    }
}
