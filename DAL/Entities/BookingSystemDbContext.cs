using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class BookingSystemDbContext : IdentityDbContext<User>
    {
        private const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
        private const string ROLE_ID = ADMIN_ID;
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<EvenSchedule> EvenSchedules { get; set; }
        public DbSet<PendingBooking> PendingBookings { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServicePlace> ServicePlaces { get; set; }
        public DbSet<ServicePlacePosition> ServicePlacePositions { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<PendingBookingPosition> PendingBookingPositions { get; set; }
        public DbSet<BookingPosition> BookingPositions { get; set; }
        public BookingSystemDbContext(DbContextOptions<BookingSystemDbContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<BookingPosition>()
                .HasKey(x => new { x.BookingId, x.ServicePlacePositionId });
            builder.Entity<BookingPosition>()
               .HasOne(bc => bc.Booking)
               .WithMany(b => b.BookingPositions)
               .HasForeignKey(bc => bc.BookingId);
            builder.Entity<BookingPosition>()
              .HasOne(bc => bc.ServicePlacePosition)
              .WithMany(b => b.BookingPositions)
              .HasForeignKey(bc => bc.ServicePlacePositionId);

            builder.Entity<PendingBookingPosition>()
               .HasKey(x => new { x.PendingBookingId, x.ServicePlacePositionId });
            builder.Entity<PendingBookingPosition>()
               .HasOne(bc => bc.PendingBooking)
               .WithMany(b => b.PendingBookingPositions)
               .HasForeignKey(bc => bc.PendingBookingId);
            builder.Entity<PendingBookingPosition>()
              .HasOne(bc => bc.ServicePlacePosition)
              .WithMany(b => b.PendingBookingPositions)
              .HasForeignKey(bc => bc.ServicePlacePositionId);

            builder.Entity<ServiceEvent>()
               .HasKey(x => new { x.EventId, x.ServiceId });
            builder.Entity<ServiceEvent>()
               .HasOne(bc => bc.Event)
               .WithMany(b => b.ServiceEvents)
               .HasForeignKey(bc => bc.EventId);
            builder.Entity<ServiceEvent>()
              .HasOne(bc => bc.Service)
              .WithMany(b => b.ServiceEvents)
              .HasForeignKey(bc => bc.ServiceId);

            SeedAdminIdentity(builder);
            SeedOtherData(builder);
        }

        private void SeedAdminIdentity(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "admin"
            });

            var hasher = new PasswordHasher<User>();
            builder.Entity<User>().HasData(new User
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@admin.hu",
                NormalizedEmail = "admin@admin.hu",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }

        private void SeedOtherData(ModelBuilder builder)
        {
            List<Image> images = new List<Image>
            {
                new Image
                {
                    Id = Guid.NewGuid(),
                    Extension = "jpg",
                    Name = "Shazam.jpg"
                },
                new Image
                {
                    Id = Guid.NewGuid(),
                    Extension = "jpg",
                    Name = "Negyszogletu.jpg"
                }
            };
            List<ServiceType> types = new List<ServiceType>
            {
                new ServiceType
                {
                    Id = Guid.NewGuid(),
                    Name = "Mozi",
                   
                },
                 new ServiceType
                {
                    Id = Guid.NewGuid(),
                    Name = "Színház",
                 
                }
            };


            List<Service> services = new List<Service>
            {
                new Service
                {
                    Id = Guid.NewGuid(),
                    Name = "Allee CC",
                    City = "Budapest",
                    Description = "Allee Cinema City mozi",
                    Street = "Október huszonharmadika u. 8-10",
                    TypeId = types[0].Id,

                },
                new Service
                {
                    Id = Guid.NewGuid(),
                    Name = "Pécs Plaza CC",
                    City = "Pécs",
                    Description = "Pécs Cinema City mozi",
                    Street = "Megyeri út 76.",
                    TypeId = types[0].Id
                },
                new Service
                {
                    Id = Guid.NewGuid(),
                    Name = "Madách Színház",
                    City = "Budapest",
                    Street = "Erzsébet krt. 29-33.",
                    TypeId = types[1].Id
                },
            };

            
            List<Event> events = new List<Event>
            {
                new Event
                {
                    Id = Guid.NewGuid(),
                    Name = "Shazam!",
                    UserId = ADMIN_ID,
                    ImageId = images[0].Id
                },
                new Event
                {
                    Id = Guid.NewGuid(),
                    Name = "Négyszögletű Kerek Erdő",
                    UserId = ADMIN_ID,
                    ImageId = images[1].Id
                },
            };
            List<ServiceEvent> serviceEvents = new List<ServiceEvent>();
            serviceEvents.Add(new ServiceEvent
            {
                EventId = events[0].Id,
                ServiceId = services[0].Id
            });
            serviceEvents.Add(new ServiceEvent
            {
                EventId = events[0].Id,
                ServiceId = services[1].Id
            });
            serviceEvents.Add(new ServiceEvent
            {
                EventId = events[1].Id,
                ServiceId = services[2].Id
            });
            ServicePlace place = new ServicePlace
            {
                Id = Guid.NewGuid(),
                ServiceId = services[0].Id
            };
            place.Name = "Anyád";

            List<ServicePlacePosition> layout = new List<ServicePlacePosition>
            {
                new ServicePlacePosition
                {
                    Id = Guid.NewGuid(),
                    Name = "I1",
                    ServicePlaceId = place.Id
                },
                new ServicePlacePosition
                {
                    Id = Guid.NewGuid(),
                    Name = "I2",
                    ServicePlaceId = place.Id
                },
                new ServicePlacePosition
                {
                    Id = Guid.NewGuid(),
                    Name = "I3",
                    ServicePlaceId = place.Id
                },
                new ServicePlacePosition
                {
                    Id = Guid.NewGuid(),
                    Name = "I4",
                    ServicePlaceId = place.Id
                }
            };


            EvenSchedule schedule = new EvenSchedule
            {
                Id = Guid.NewGuid(),
                Description = "Shazam bemutató",
                ServiceId = services[0].Id,
                EventId = events[0].Id,
                ServicePlaceId = place.Id,
                From = DateTime.Now,
                To = DateTime.Now.AddHours(2)
            };
            builder.Entity<Image>().HasData(images.ToArray());
            builder.Entity<ServiceType>().HasData(types.ToArray());
            builder.Entity<ServicePlace>().HasData(new ServicePlace[] { place });
            builder.Entity<Service>().HasData(services.ToArray());
            builder.Entity<ServicePlacePosition>().HasData(layout.ToArray());
            builder.Entity<EvenSchedule>().HasData(new EvenSchedule[] { schedule });
            builder.Entity<Event>().HasData(events.ToArray());
            builder.Entity<ServiceEvent>().HasData(serviceEvents.ToArray());
            
        }
    }
}
