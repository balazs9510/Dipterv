using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class User : IdentityUser
    {
        public ICollection<Event> Event { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<ServicePlace> ServicePlaces { get; set; }
        public ICollection<EvenSchedule> EvenSchedules { get; set; }

    }
}
