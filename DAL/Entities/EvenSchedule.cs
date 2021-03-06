﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class EvenSchedule
    {
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Időpont kezdete")]
        public DateTime From { get; set; }
        [Display(Name = "Időpont vége")]
        public DateTime? To { get; set; }
        [Required]
        [StringLength(200)]
        [Display(Name = "Leírás")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Esemény")]
        public Guid EventId { get; set; }
        public Event Event { get; set; }
        [Required]
        [Display(Name = "Szolgáltatás")]
        public Guid ServiceId { get; set; }
        [Display(Name = "Szolgáltatás")]
        public Service Service { get; set; }
        [Required]
        [Display(Name = "Helyszín")]
        public Guid ServicePlaceId { get; set; }
        [Display(Name = "Helyszín")]
        public ServicePlace ServicePlace { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public ICollection<Booking> Bookings { get; set; }
        public ICollection<PendingBooking> PendingBookings { get; set; }
    }
}
