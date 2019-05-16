using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PublicWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _service;
        public ImageController(IImageService service)
        {
            _service = service;
        }
        [ResponseCache(Duration = 120)]
        public virtual IActionResult GetImage()
        {
            return File(System.IO.File.ReadAllBytes(@".\AppData\no-image.png"), "image/png");
        }
        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetImage(Guid? id)
        {
            try
            {
                if (id.HasValue)
                {
                    var image = await _service.GetImageAsync(id.Value);
                    var memoryStream = new MemoryStream(image.Content);
                    return File(image.Content, "image/png");
                }
                else
                {
                    return File(System.IO.File.ReadAllBytes(@".\AppData\no-avaible-image.png"), "image/png");
                }

            }
            catch
            {
                // log
            }
            return BadRequest();
        }
    }
}