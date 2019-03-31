using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class EventScheduleDateGroup
    {
        public DateTime Date { get; set; }
        public List<EvenSchedule> EventSchedules { get; set; }
    }
}
