using Microsoft.AspNetCore.Mvc;
using Sharepoint.Data.Model;
using Sharepoint.Service;

namespace Sharepoint_System.Controllers
{
    [ApiController]
    [Route("api/galleries")]
    public class GalleryController : Controller
    {
        private readonly ILogger<GalleryController> logger;
        private readonly IGalleryService galleryService;

        public GalleryController(ILogger<GalleryController> logger, IGalleryService galleryService)
        {
            this.logger = logger;
            this.galleryService = galleryService;
        }
        [HttpPost]
        public async Task<IActionResult> Creates([FromBody] List<Gallery> galleries)
        {
            var result = await galleryService.AddGalleries(galleries);
            return result ? Ok() : BadRequest();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] String id)
        {
            var result = await galleryService.GetById(id);

            return result != null ? Ok(result) : BadRequest();
        }
        [HttpGet()]
        public async Task<IActionResult> Get([FromQuery] GalleryType type, [FromQuery] int page = 1, int pageSize = 4)
        {
            var list = await galleryService.GetAll(type);
            var result = list.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return result != null ? Ok(result) : BadRequest();
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Gallery gallery)
        {
            var result = await galleryService.Update(gallery);
            return result ? Ok() : BadRequest();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] String id)
        {
            var result = await galleryService.Delete(id);
            return result ? Ok() : BadRequest();
        }
    }
}
