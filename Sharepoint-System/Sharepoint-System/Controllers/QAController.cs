using Microsoft.AspNetCore.Mvc;
using Sharepoint.Data.Model;
using Sharepoint.Service;

namespace Sharepoint_System.Controllers
{
    [ApiController]
    [Route("api/qas")]
    public class QAController : Controller
    {
        private readonly ILogger<QAController> logger;
        private readonly IQAService qAService;

        public QAController(ILogger<QAController> logger, IQAService qAService)
        {
            this.logger = logger;
            this.qAService = qAService;
        }

        [HttpGet("/api/qa/{id}")]
        public async Task<IActionResult> Get([FromRoute] String id) {
            var result = await qAService.GetById(id);

            return result != null ? Ok(result) : BadRequest();
        }
        [HttpGet("/api/qas")]
        public async Task<IActionResult> Get([FromQuery] int page = 1, int pageSize = 4)
        {
            var list = await qAService.GetAll();
            var result = list.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return result != null ? Ok(result) : BadRequest();
        }
        [HttpPost]
        public async Task<IActionResult> Import([FromBody] List<QA> qas)
        {
            var result = await qAService.AddQas(qas);
            return result ? Ok() : BadRequest();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] String Id)
        {
            var result = await qAService.Delete(Id);
            return result ? Ok() : BadRequest();
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] QA qa)
        {
            var result = await qAService.Update(qa);
            return result ? Ok() : BadRequest();
        }
    }
}
