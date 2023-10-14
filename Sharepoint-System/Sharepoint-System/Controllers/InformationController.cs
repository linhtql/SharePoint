using Microsoft.AspNetCore.Mvc;
using Sharepoint.Data.Model;
using Sharepoint.Service;

namespace Sharepoint_System.Controllers
{
    [ApiController]
    [Route("api/informations")]
    public class InformationController : Controller
    {
        private readonly ILogger<InformationController> logger;
        private readonly IInformationsService informationsService;

        public InformationController(ILogger<InformationController> logger, IInformationsService informationsService)
        {
            this.logger = logger;
            this.informationsService = informationsService;
        }
        [HttpPost]
        public async Task<IActionResult> ImportInformations([FromBody] List<Information> informations)
        {
            var result = await informationsService.AddInformations(informations);
            return result ? Ok() : BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetInformation([FromQuery] InformationType type = 0, [FromQuery] int page = 1, [FromQuery] int pageSize = 4)
        {
            var list = await informationsService.GetAllInformationsByType((InformationType)type);
            var result = list.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] String id)
        {
            var isDeleteed = await informationsService.DeleteInformation(id);
            return isDeleteed ? Ok() : BadRequest("Id not found");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Information information)
        {
            var result = await informationsService.Update(information);
            if (result)
            {
                return Ok();
            }
            return BadRequest(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetInformation([FromRoute] String id)
        {
            var result = await informationsService.GetInformationById(id);
            if (result == null)
            {
                return BadRequest("Id Not Found");
            }
            return Ok(result);
        }
    }
}
