using MediatR;
using MediatRDemo.Ports;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatRDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMediator Mediator;
        public MessageController(IMediator mediator) => Mediator = mediator;

        [HttpGet("send-with-mediator1")]
        public IActionResult Get()
        {
            return Ok(Mediator.Send(new Ping()).Result);
        }

        [HttpGet("send-with-mediator2")]
        public IActionResult Get2()
        {
            return Ok(Mediator.Send(new OneWay()));
        }

        [HttpGet("send-with-mediator3")]
        public IActionResult Get3()
        {
            var presenter = new Presenter();
            Mediator.Send(new CreateProduct("Arroz", presenter));
            return Ok(presenter.Content);
        }

        [HttpGet("send-notiofication")]
        public IActionResult Get4()
        {
            Mediator.Publish(new PingNotification());
            return Ok();
        }
    }
}
