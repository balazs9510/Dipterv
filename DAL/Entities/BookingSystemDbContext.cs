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
        public DbSet<EvenSchedule> EvenSchedules { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServicePlace> ServicePlaces { get; set; }
        public DbSet<ServicePlacePosition> ServicePlacePositions { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public BookingSystemDbContext(DbContextOptions<BookingSystemDbContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
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
            List<ServiceType> types = new List<ServiceType>
            {
                new ServiceType
                {
                    Id = Guid.NewGuid(),
                    Name = "Mozi"
                },
                 new ServiceType
                {
                    Id = Guid.NewGuid(),
                    Name = "Színház"
                }
            };
            builder.Entity<ServiceType>().HasData(types.ToArray());
            List<Service> services = new List<Service>
            {
                new Service
                {
                    Id = Guid.NewGuid(),
                    Name = "Allee CC",
                    City = "Budapest",
                    Description = "Allee Cinema City mozi",
                    Street = "Október huszonharmadika u. 8-10",
                    TypeId = types[0].Id
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
                    UserId = ADMIN_ID
                },
                new Event
                {
                    Id = Guid.NewGuid(),
                    Name = "Négyszögletű Kerek Erdő",
                    UserId = ADMIN_ID
                },
            };
            builder.Entity<Service>().HasData(services.ToArray());
            builder.Entity<Event>().HasData(events.ToArray());
        }
    }
}
