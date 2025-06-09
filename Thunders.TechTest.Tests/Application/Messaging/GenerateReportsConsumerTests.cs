using Moq;
using Thunders.TechTest.ApiService.Application.Interfaces;
using Thunders.TechTest.ApiService.Infrastructure.Messaging;
using Thunders.TechTest.ApiService.Domain.Enums;

namespace Thunders.TechTest.Tests.Application.Messaging;

public class GenerateReportsConsumerTests
{
    [Fact]
    public async Task Handle_Should_Invoke_All_Report_Methods()
    {
        var mock = new Mock<ITollUsageRepository>();
        mock.Setup(r => r.GetByCityGroupedByHourAsync()).ReturnsAsync([]);
        mock.Setup(r => r.GetTopStationsByMonthAsync(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync([]);
        mock.Setup(r => r.GetVehicleTypeCountsByStationAsync(It.IsAny<string>())).ReturnsAsync(new Dictionary<VehicleType, int>());

        var consumer = new GenerateReportsConsumer(mock.Object);
        await consumer.Handle(new GenerateReportsMessage(2025, 2));

        mock.Verify(r => r.GetByCityGroupedByHourAsync(), Times.Once);
        mock.Verify(r => r.GetTopStationsByMonthAsync(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        mock.Verify(r => r.GetVehicleTypeCountsByStationAsync(It.IsAny<string>()), Times.Once);
    }
}
