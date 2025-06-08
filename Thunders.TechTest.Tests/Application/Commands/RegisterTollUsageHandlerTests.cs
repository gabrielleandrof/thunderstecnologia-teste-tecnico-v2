using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Moq;
using Thunders.TechTest.ApiService.Application.Commands.RegisterTollUsage;
using Thunders.TechTest.ApiService.Application.Interfaces;
using Thunders.TechTest.ApiService.Domain.Entities;
using Thunders.TechTest.ApiService.Domain.Enums;
using Thunders.TechTest.ApiService.Infrastructure.Persistence;

namespace Thunders.TechTest.Tests.Application.Commands;

public class RegisterTollUsageHandlerTests
{
    [Fact]
    public async Task Handle_Should_Call_AddAsync_With_Correct_Data()
    {
        var mockRepo = new Mock<ITollUsageRepository>();
        var handler = new RegisterTollUsageHandler(mockRepo.Object);

        var command = new RegisterTollUsageCommand(
            Timestamp: new DateTime(2025, 6, 7, 14, 0, 0),
            TollStation: "Station X",
            City: "Rio de Janeiro",
            State: "RJ",
            AmountPaid: 15.75m,
            VehicleType: VehicleType.Car
        );

        await handler.Handle(command, CancellationToken.None);

        mockRepo.Verify(r => r.AddAsync(It.Is<TollUsage>(t =>
            t.Timestamp == command.Timestamp &&
            t.TollStation == command.TollStation &&
            t.City == command.City &&
            t.State == command.State &&
            t.AmountPaid == command.AmountPaid &&
            t.VehicleType == command.VehicleType
        )), Times.Once);
    }

    [Fact]
    public async Task TollUsageRepository_Should_Persist_And_Query_Correctly()
    {
        var options = new DbContextOptionsBuilder<TollDbContext>()
            .UseInMemoryDatabase(databaseName: "ThundersUnitTestDb")
            .Options;

        await using var context = new TollDbContext(options);
        var repository = new TollUsageRepository(context);

        var entry = new TollUsage
        {
            Timestamp = new DateTime(2025, 6, 7, 10, 30, 0),
            TollStation = "Station A",
            City = "Campinas",
            State = "SP",
            AmountPaid = 10.0m,
            VehicleType = VehicleType.Truck
        };

        await repository.AddAsync(entry);

        var all = await repository.GetAllAsync();
        all.Should().ContainSingle();

        var byHour = await repository.GetByCityGroupedByHourAsync();
        byHour.Should().Contain(x => x.City == "Campinas" && x.Total == 10.0m);

        var top = await repository.GetTopStationsByMonthAsync(2025, 6, 1);
        top.Should().ContainSingle(x => x.TollStation == "Station A" && x.Total == 10.0m);

        var types = await repository.GetVehicleTypeCountsByStationAsync("Station A");
        types[VehicleType.Truck].Should().Be(1);
    }
}
