using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SeedServices
{
    public interface IImageSeedService
    {
        Task SeedImagesAsync();
    }
}
