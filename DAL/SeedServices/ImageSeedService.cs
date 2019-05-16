using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.SeedServices
{
    public class ImageSeedService : IImageSeedService
    {
        private readonly BookingSystemDbContext _context;

        public ImageSeedService(BookingSystemDbContext context) => _context = context;
        public async Task SeedImagesAsync()
        {
            if (_context.Images.Any(x => x.Content == null))
            {
                foreach (var image in _context.Images.Where(x => x.Content == null))
                {
                    image.Content = await File.ReadAllBytesAsync(@".\AppData\DefaultImages\" + image.Name);
                }
                await _context.SaveChangesAsync();
            }
        }
    }
}
