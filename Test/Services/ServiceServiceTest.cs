using BLL.SearchParamters;
using BLL.Services;
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
    public class ServiceServiceTest
    {
        private readonly SeedService _seedService = new SeedService();

        [Fact]
        public async Task GetServiceTypes()
        {
            // Arrange
            using (var context = DbContextHelper.GetInMemoryDbContext())
            {
                var service = new ServiceService(context);               
                int expectedCount = context.ServiceTypes.Count();

                // Act
                var serviceTypes = await service.GetServiceTypesAsync();

                // Assert
                Assert.Equal(expectedCount, serviceTypes.Count);
            }
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public async Task GetTop(int count)
        {
            // Arrange
            using (var context = DbContextHelper.GetInMemoryDbContext())
            {
                var service = new ServiceService(context);
                var expectedCount = Math.Min(count, context.Services.Count());
                // Act
                var services = await service.GetTopAsync(count);

                // Assert
                Assert.Equal(expectedCount, services.Count);
            }
        }

        [Theory]
        [InlineData("allee")]
        [InlineData("Cinema City")]
        [InlineData("test")]
        public async Task GetServiceListWithName(string nameOfService)
        {
            // Arrange
            using (var context = DbContextHelper.GetInMemoryDbContext())
            {
                var service = new ServiceService(context);
                var searchParameter = new ServiceSearchParameter
                {
                    Name = nameOfService
                };

                // Act
                var events = await service.GetServicesAsync(searchParameter);

                // Assert
                Assert.True(!events.Any(x => !x.Name.Contains(nameOfService)));
            }
        }
    }
}
