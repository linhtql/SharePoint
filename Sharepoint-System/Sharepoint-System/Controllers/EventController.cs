using Microsoft.AspNetCore.Mvc;
using Sharepoint.Data.Model;
using Sharepoint.Service;

namespace Sharepoint_System.Controllers
{
    [ApiController]
    [Route("api/events")]
    public class EventController : Controller
    {
        private readonly ILogger<EventController> logger;
        private readonly IEventService eventService;

        public EventController(ILogger<EventController> logger, IEventService eventService)
        {
            this.logger = logger;
            this.eventService = eventService;
        }
        [HttpPost]
        public async Task<IActionResult> Creates([FromBody] List<Event> events)
        {
            var result = await eventService.AddEvents(events);
            return result ? Ok() : BadRequest();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] String id)
        {
            var result = await eventService.GetById(id);

            return result != null ? Ok(result) : BadRequest();
        }
        [HttpGet()]
        public async Task<IActionResult> Get([FromQuery] int page = 1, int pageSize = 4)
        {
            var list = await eventService.GetAll();
            var result = list.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return result != null ? Ok(result) : BadRequest();
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Event eventt)
        {
            var result = await eventService.Update(eventt);
            return result ? Ok() : BadRequest();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] String Id)
        {
            var result = await eventService.Delete(Id);
            return result ? Ok() : BadRequest();
        }

    }
}
