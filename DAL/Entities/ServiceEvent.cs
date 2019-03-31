using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class ServiceEvent
    {
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }
        public Guid EventId { get; set; }
        public Event Event { get; set; }
    }
}
