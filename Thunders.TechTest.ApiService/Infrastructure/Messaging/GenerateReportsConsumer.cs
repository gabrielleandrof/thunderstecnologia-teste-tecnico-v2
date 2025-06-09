using Rebus.Handlers;
using Thunders.TechTest.ApiService.Application.Interfaces;

namespace Thunders.TechTest.ApiService.Infrastructure.Messaging;

public class GenerateReportsConsumer : IHandleMessages<GenerateReportsMessage>
{
    private readonly ITollUsageRepository _repository;

    public GenerateReportsConsumer(ITollUsageRepository repository)
    {
        _repository = repository;
    }

    public async Task Handle(GenerateReportsMessage message)
    {
        var hourly = await _repository.GetByCityGroupedByHourAsync();
        var top = await _repository.GetTopStationsByMonthAsync(message.Year, message.Month, 5);
        var types = await _repository.GetVehicleTypeCountsByStationAsync("Station A");

        Console.WriteLine($"[MSG] Hourly: {hourly.Count}, Top: {top.Count}, Types: {types.Count}");
    }
}
