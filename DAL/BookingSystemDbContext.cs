using DAL.Entities;
using DAL.EntityConfigurations;
using DAL.SeedServices;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL
{
    public class BookingSystemDbContext : IdentityDbContext<User>
    {
        private readonly ISeedService _seedService;
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
        public BookingSystemDbContext(DbContextOptions<BookingSystemDbContext> options, ISeedService seedService)
            : base(options) => _seedService = seedService;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<BookingPosition>()
                .HasKey(x => new { x.BookingId, x.ServicePlacePositionId });
            builder.Entity<BookingPosition>()
               .HasOne(bc => bc.Booking)
               .WithMany(b => b.BookingPositions)
               .HasForeignKey(bc => bc.BookingId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<BookingPosition>()
              .HasOne(bc => bc.ServicePlacePosition)
              .WithMany(b => b.BookingPositions)
              .HasForeignKey(bc => bc.ServicePlacePositionId)
              .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<PendingBookingPosition>()
               .HasKey(x => new { x.PendingBookingId, x.ServicePlacePositionId });
            builder.Entity<PendingBookingPosition>()
               .HasOne(bc => bc.PendingBooking)
               .WithMany(b => b.PendingBookingPositions)
               .HasForeignKey(bc => bc.PendingBookingId)
               .OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<PendingBookingPosition>()
              .HasOne(bc => bc.ServicePlacePosition)
              .WithMany(b => b.PendingBookingPositions)
              .HasForeignKey(bc => bc.ServicePlacePositionId)
              .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<ServiceEvent>()
               .HasKey(x => new { x.EventId, x.ServiceId });
            builder.Entity<ServiceEvent>()
               .HasOne(bc => bc.Event)
               .WithMany(b => b.ServiceEvents)
               .HasForeignKey(bc => bc.EventId)
               .OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<ServiceEvent>()
              .HasOne(bc => bc.Service)
              .WithMany(b => b.ServiceEvents)
              .HasForeignKey(bc => bc.ServiceId)
              .OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<EvenSchedule>()
              .HasOne(x => x.ServicePlace)
              .WithMany(x => x.EvenSchedules)
              .OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<EvenSchedule>()
              .HasOne(x => x.Event)
              .WithMany(x => x.EvenSchedules)
              .OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<EvenSchedule>()
              .HasOne(x => x.Service)
              .WithMany(x => x.EvenSchedules)
              .OnDelete(DeleteBehavior.ClientSetNull);

            builder.ApplyConfiguration(new RoleEntityConfiguration(_seedService));
            builder.ApplyConfiguration(new UserEntityConfiguration(_seedService));
            builder.ApplyConfiguration(new UserRoleEntityConfiguration(_seedService));
            builder.ApplyConfiguration(new ImageEntityConfiguration(_seedService));
            builder.ApplyConfiguration(new ServiceTypeEntityConfiguration(_seedService));
            builder.Entity<Service>().HasData(_seedService.Services.Values.ToArray());
            builder.Entity<Event>().HasData(_seedService.Events.Values.ToArray());
            builder.Entity<ServiceEvent>().HasData(_seedService.ServiceEvents.ToArray());
            builder.Entity<ServicePlace>().HasData(_seedService.ServicePlaces.Values.ToArray());
            builder.Entity<ServicePlacePosition>().HasData(_seedService.ServicePlacePositions.ToArray());
            builder.Entity<EvenSchedule>().HasData(_seedService.EvenSchedules.ToArray());
        }
    }
}
