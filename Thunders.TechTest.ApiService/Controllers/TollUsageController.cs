using MediatR;
using Microsoft.AspNetCore.Mvc;
using Thunders.TechTest.ApiService.Application.Commands.RegisterTollUsage;
using Thunders.TechTest.ApiService.Application.Interfaces;
using Thunders.TechTest.ApiService.Infrastructure.Messaging;
using Thunders.TechTest.OutOfBox.Queues;

namespace Thunders.TechTest.ApiService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TollUsageController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ITollUsageRepository _repository;
    private readonly IMessageSender _sender;

    public TollUsageController(IMediator mediator, ITollUsageRepository repository, IMessageSender sender)
    {
        _mediator = mediator;
        _repository = repository;
        _sender = sender;
    }

    [HttpPost]
    public async Task<IActionResult> Register([FromBody] RegisterTollUsageCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }

    [HttpGet("report/hourly-city")]
    public async Task<IActionResult> GetHourlyByCity()
    {
        var result = await _repository.GetByCityGroupedByHourAsync();
        return Ok(result);
    }

    [HttpGet("report/top-stations")]
    public async Task<IActionResult> GetTopStations([FromQuery] int year, [FromQuery] int month, [FromQuery] int top = 5)
    {
        var result = await _repository.GetTopStationsByMonthAsync(year, month, top);
        return Ok(result);
    }

    [HttpGet("report/vehicle-count")]
    public async Task<IActionResult> GetVehicleTypeCount([FromQuery] string station)
    {
        var result = await _repository.GetVehicleTypeCountsByStationAsync(station);
        return Ok(result);
    }

    [HttpPost("report/trigger")]
    public async Task<IActionResult> TriggerReport()
    {
        await _sender.SendLocal(new GenerateReportsMessage());
        return Accepted();
    }
}
