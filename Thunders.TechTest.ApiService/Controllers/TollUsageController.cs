using MediatR;
using Microsoft.AspNetCore.Mvc;
using Thunders.TechTest.ApiService.Application.Commands.RegisterTollUsage;

namespace Thunders.TechTest.ApiService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TollUsageController : ControllerBase
{
    private readonly IMediator _mediator;

    public TollUsageController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Register([FromBody] RegisterTollUsageCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }
}
