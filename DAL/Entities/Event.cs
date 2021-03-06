﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Event
    {
        public Guid Id { get; set; }
        [StringLength(500)]
        [Display(Name = "Leírás")]
        public string Description { get; set; }
        
        [Required]
        [StringLength(250)]
        [Display(Name = "Név")]
        public string Name { get; set; }
        [Required]
        public string UserId { get; set; }
        public User User { get; set; }
        public Guid ImageId { get; set; }
        public Image Image { get; set; }
        public List<ServiceEvent> ServiceEvents { get; set; }
        public List<EvenSchedule> EvenSchedules { get; set; }
    }
}