using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rebus.Bus;
using SmartDrop.Infrastructure.Messaging.Messages;

namespace SmartDrops.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AssignmentController : ControllerBase
{
    private readonly IBus _bus;

    public AssignmentController(IBus bus)
    {
        _bus = bus;
    }

    [HttpPost("complete")]
    public async Task<IActionResult> CompleteDrop([FromBody] Guid requestId)
    {
        var @event = new DropCompletedEvent
        {
            RequestId = requestId
        };

        await _bus.Publish(@event);

        return Ok(new { message = "DropCompletedEvent published successfully", requestId });
    }
}

