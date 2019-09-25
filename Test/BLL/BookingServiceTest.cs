using BLL.Services;
using DAL.Entities;
using DAL.SeedServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Helpers;
using Xunit;

namespace Test.BLL
{
    public class BookingServiceTest
    {
        private readonly SeedService _seedService = new SeedService();

        [Fact]
        public async Task CreatePendingBookingForOneSeat()
        {
            // Arrange
            using (var context = DbContextHelper.GetInMemoryDbContext())
            {
                var service = new BookingService(context);
                Guid id = Guid.NewGuid();
                var pendingBooking = new PendingBooking()
                {
                    Id = id,
                    Date = DateTime.Now,
                    EvenScheduleId = _seedService.EvenSchedules.First().Id,
                    ExpirationDate = DateTime.Now.AddMinutes(2),
                    PendingBookingPositions = new List<PendingBookingPosition>
                    {
                        new PendingBookingPosition
                        {
                            PendingBookingId = id,
                            ServicePlacePositionId = _seedService.ServicePlacePositions[0].Id
                        }
                    }
                };
                int expectedSeat = 1;

                // Act
                var pendingBookingFromDb = await service.CreatePendingBookingAsync(pendingBooking);

                // Assert
                Assert.True(pendingBookingFromDb.PendingBookingPositions.Count == expectedSeat);
            }
        }
        [Fact]
        public async Task CreatePendingBookingForTwoSeat()
        {
            // Arrange
            using (var context = DbContextHelper.GetInMemoryDbContext())
            {
                var service = new BookingService(context);
                Guid id = Guid.NewGuid();
                var pendingBooking = new PendingBooking()
                {
                    Id = id,
                    Date = DateTime.Now,
                    EvenScheduleId = _seedService.EvenSchedules.First().Id,
                    ExpirationDate = DateTime.Now.AddMinutes(2),
                    PendingBookingPositions = new List<PendingBookingPosition>
                    {
                        new PendingBookingPosition
                        {
                            PendingBookingId = id,
                            ServicePlacePositionId = _seedService.ServicePlacePositions[1].Id
                        },
                        new PendingBookingPosition
                        {
                            PendingBookingId = id,
                            ServicePlacePositionId = _seedService.ServicePlacePositions[2].Id
                        }
                    }
                };
                int expectedSeat = 2;

                // Act
                var pendingBookingFromDb = await service.CreatePendingBookingAsync(pendingBooking);

                // Assert
                Assert.True(pendingBookingFromDb.PendingBookingPositions.Count == expectedSeat);
            }
        }
    }
}
