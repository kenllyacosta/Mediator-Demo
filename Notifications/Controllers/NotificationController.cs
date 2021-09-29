using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Notifications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        readonly IMediator Mediator;
        public NotificationController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            PersistenceService persistenceService = 
                new PersistenceService(Mediator);

            persistenceService.SaveChanges();

            return Ok("Saved!");
        }
    }
}
