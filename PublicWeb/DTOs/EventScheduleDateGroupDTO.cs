using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWeb.DTOs
{
    public class EventScheduleDateGroupDTO
    {
        public DateTime Date { get; set; }
        public List<EventScheduleDTO> EventSchedules { get; set; }
    }
}
