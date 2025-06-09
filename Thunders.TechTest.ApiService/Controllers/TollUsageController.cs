using MediatR;
using Microsoft.AspNetCore.Mvc;
using Thunders.TechTest.ApiService.Application.Commands.RegisterTollUsage;
using Thunders.TechTest.ApiService.Application.Interfaces;
using Thunders.TechTest.ApiService.Infrastructure.Messaging;
using Thunders.TechTest.ApiService.Responses.TollUsage;
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

        var response = result.Select(x => new HourlyTollUsageReportResponse
        {
            City = x.City,
            Hour = x.Hour,
            Total = x.Total
        });

        return Ok(response);
    }

    [HttpGet("report/top-stations")]
    public async Task<IActionResult> GetTopStations([FromQuery] int year, [FromQuery] int month, [FromQuery] int top = 5)
    {
        var result = await _repository.GetTopStationsByMonthAsync(year, month, top);

        var response = result.Select(x => new TopTollStationsReportResponse
        {
            TollStation = x.TollStation,
            Total = x.Total
        });

        return Ok(response);
    }

    [HttpGet("report/vehicle-count")]
    public async Task<IActionResult> GetVehicleTypeCount([FromQuery] string station)
    {
        var result = await _repository.GetVehicleTypeCountsByStationAsync(station);

        var response = result.Select(x => new VehicleTypeCountReportResponse
        {
            VehicleType = (int)x.Key,
            Count = x.Value
        });

        return Ok(response);
    }

    [HttpPost("report/trigger")]
    public async Task<IActionResult> TriggerReport(int year, int month)
    {
        await _sender.SendLocal(new GenerateReportsMessage(year, month));

        var response = new TriggerReportResponse
        {
            Status = "Accepted",
            Message = "Report generation has been triggered successfully."
        };

        return Accepted(response);
    }
}
