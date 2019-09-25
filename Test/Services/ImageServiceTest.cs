using BLL.Services;
using DAL.Entities;
using DAL.SeedServices;
using System;
using System.Threading.Tasks;
using Test.Helpers;
using Xunit;

namespace Test.Services
{
    public class ImageServiceTest
    {
        private readonly SeedService _seedService = new SeedService();

        [Fact]
        public async Task GetImageWithIdWhenInserted()
        {
            // Arrange
            using (var context = DbContextHelper.GetInMemoryDbContext())
            {
                var service = new ImageService(context);
                var imageToAdd = new Image
                {
                    Id = Guid.NewGuid(),
                    Name = "test.png",
                    Extension = "png"
                };
                context.Images.Add(imageToAdd);
                await context.SaveChangesAsync();

                // Act
                var imageFromDb = await service.GetImageAsync(imageToAdd.Id);

                // Assert
                Assert.True(imageFromDb.Name == imageToAdd.Name);
                Assert.True(imageFromDb.Extension == imageToAdd.Extension);
                Assert.True(imageFromDb.Id == imageToAdd.Id);
            }
        }

        [Theory]
        [InlineData("1572F8D1-2A65-489A-872B-F0F62E893127", null)]
        [InlineData("2ECC93E0-08E2-4B00-8197-3FEDE4B3AA4D", "test.png")]
        public async Task GetImageWithId(string imageIdString, string expectedName)
        {
            // Arrange
            using (var context = DbContextHelper.GetInMemoryDbContext())
            {
                var service = new ImageService(context);
                var imageId = Guid.Parse(imageIdString);

                // Act
                var imageFromDb = await service.GetImageAsync(imageId);

                // Assert
                Assert.Equal(expectedName, imageFromDb?.Name);
            }
        }
    }
}
