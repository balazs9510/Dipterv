using BLL.SearchParamters;
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
    public class EventServiceTest
    {
        private readonly SeedService _seedService = new SeedService();

        [Fact]
        public async Task GetTopFive()
        {
                // Arrange
            using (var context = DbContextHelper.GetInMemoryDbContext())
            {
                var service = new EventService(context);
                int expectedCount = 5;

                // Act
                var events = await service.GetTopAsync(5);

                // Assert
                Assert.True(events.Count == expectedCount);
            }           
        }

        [Fact]
        public async Task GetEventWithId()
        {
            // Arrange
            using (var context = DbContextHelper.GetInMemoryDbContext())
            {
                var service = new EventService(context);
                var eventToAdd = new Event
                {
                    Id = Guid.NewGuid(),
                    Description = "test",
                    Name = "test",
                    UserId = _seedService.Users.First().Key,     
                    Image = new Image
                    {
                        Id = Guid.NewGuid()
                    }
                };
                context.Events.Add(eventToAdd);
                await context.SaveChangesAsync();

                // Act
                var eventFromDb = await service.GetEventAsync(eventToAdd.Id);

                // Assert
                Assert.True(eventFromDb.Name == eventToAdd.Name);
                Assert.True(eventFromDb.Description == eventToAdd.Description);
                Assert.True(eventFromDb.UserId == eventToAdd.UserId);
                Assert.True(eventFromDb.Id == eventToAdd.Id);
            }
        }

        [Theory]
        [InlineData("Shazam")]
        [InlineData("teeest")]
        public async Task GetEventListWithName(string nameOfEvent)
        {
            // Arrange
            using (var context = DbContextHelper.GetInMemoryDbContext())
            {
                var service = new EventService(context);
                var searchParameter = new EventSearchParameter
                {
                    Name = nameOfEvent
                };

                // Act
                var events = await service.GetEventsAsync(searchParameter);

                // Assert
                Assert.True(!events.Any(x => !x.Name.StartsWith(nameOfEvent)));
            }
        }
    }
}
