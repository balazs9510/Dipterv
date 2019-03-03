using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWeb.DTOs
{
    public class ServicePlaceDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ServiceId { get; set; }
        public List<ServicePlacePositionDTO> Layout { get; set; }
    }
}
