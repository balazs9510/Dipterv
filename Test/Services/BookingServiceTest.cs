using BLL.Exceptions;
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

namespace Test.Services
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

        [Fact]
        public async Task ThrowExceptionWhenSameSeatSelected()
        {
            // Arrange
            using (var context = DbContextHelper.GetInMemoryDbContext())
            {
                var service = new BookingService(context);
                Guid id = Guid.NewGuid();
                var pendingBookingFirst = new PendingBooking()
                {
                    Id = id,
                    Date = DateTime.Now,
                    EvenScheduleId = _seedService.EvenSchedules[1].Id,
                    ExpirationDate = DateTime.Now.AddMinutes(2),
                    PendingBookingPositions = new List<PendingBookingPosition>
                    {
                        new PendingBookingPosition
                        {
                            PendingBookingId = id,
                            ServicePlacePositionId = _seedService.ServicePlacePositions[1].Id
                        }
                    }
                };
                var idSecond = Guid.NewGuid();
                var pendingBookingSecond = new PendingBooking()
                {
                    Id = idSecond,
                    Date = DateTime.Now,
                    EvenScheduleId = _seedService.EvenSchedules[1].Id,
                    ExpirationDate = DateTime.Now.AddMinutes(2),
                    PendingBookingPositions = new List<PendingBookingPosition>
                    {
                        new PendingBookingPosition
                        {
                            PendingBookingId = idSecond,
                            ServicePlacePositionId = _seedService.ServicePlacePositions[1].Id
                        }
                    }
                };

                // Act
                await service.CreatePendingBookingAsync(pendingBookingFirst);

                // Assert
                await Assert.ThrowsAsync<BookingException>(async () => await service.CreatePendingBookingAsync(pendingBookingSecond));
            }
        }

        [Fact]
        public async Task CreateBookingForOneSeat()
        {
            // Arrange
            using (var context = DbContextHelper.GetInMemoryDbContext())
            {
                var service = new BookingService(context);
                Guid id = Guid.NewGuid();
                var booking = new Booking()
                {
                    Id = id.ToString(),
                    Date = DateTime.Now,
                    ScheduleId = _seedService.EvenSchedules.First().Id,
                    BookingPositions = new List<BookingPosition>
                    {
                        new BookingPosition
                        {
                            BookingId = id.ToString(),
                            ServicePlacePositionId = _seedService.ServicePlacePositions[0].Id
                        }
                    }
                };
                int expectedSeat = 1;

                // Act
                var bookingFromDb = await service.CreateBookingAsync(booking);

                // Assert
                Assert.True(booking.BookingPositions.Count == expectedSeat);
            }
        }

        [Fact]
        public async Task CreateBookingForTwoSeat()
        {
            // Arrange
            using (var context = DbContextHelper.GetInMemoryDbContext())
            {
                var service = new BookingService(context);
                Guid id = Guid.NewGuid();
                var booking = new Booking()
                {
                    Id = id.ToString(),
                    Date = DateTime.Now,
                    ScheduleId = _seedService.EvenSchedules.First().Id,
                    BookingPositions = new List<BookingPosition>
                    {
                        new BookingPosition
                        {
                            BookingId = id.ToString(),
                            ServicePlacePositionId = _seedService.ServicePlacePositions[1].Id
                        },
                        new BookingPosition
                        {
                            BookingId = id.ToString(),
                            ServicePlacePositionId = _seedService.ServicePlacePositions[2].Id
                        },
                    }
                };
                int expectedSeat = 2;

                // Act
                var bookingFromDb = await service.CreateBookingAsync(booking);

                // Assert
                Assert.True(booking.BookingPositions.Count == expectedSeat);
            }
        }
    }
}
