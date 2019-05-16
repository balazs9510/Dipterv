using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;

namespace BLL.Services
{
    public class ImageService : IImageService
    {
        private readonly BookingSystemDbContext _ctx;
        public ImageService(BookingSystemDbContext context)
        {
            _ctx = context;
        }
        public async Task<Image> GetImageAsync(Guid id)
        {
            return await _ctx.Images.FindAsync(id);
        }
    }
}
