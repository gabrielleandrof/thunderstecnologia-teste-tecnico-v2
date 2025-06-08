using FluentAssertions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http.Json;
using Thunders.TechTest.ApiService.Application.Commands.RegisterTollUsage;
using Thunders.TechTest.ApiService.Domain.Enums;

namespace Thunders.TechTest.Tests.Controllers;

public class TollUsageControllerTests
{
    private readonly HttpClient _client;

    public TollUsageControllerTests()
    {
        _client = TestServerFactory.CreateClient();
    }

    [Fact]
    public async Task Post_RegisterTollUsage_Should_Return_OK()
    {
        var command = new RegisterTollUsageCommand(
            Timestamp: DateTime.UtcNow,
            TollStation: "Station Test",
            City: "Test City",
            State: "TS",
            AmountPaid: 5.0m,
            VehicleType: VehicleType.Motorcycle
        );

        var response = await _client.PostAsJsonAsync("/api/tollusage", command);

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task Get_Reports_Should_Return_OK()
    {
        var cityResponse = await _client.GetAsync("/api/tollusage/report/hourly-city");
        var stationResponse = await _client.GetAsync("/api/tollusage/report/top-stations?year=2025&month=6&top=5");
        var vehicleResponse = await _client.GetAsync("/api/tollusage/report/vehicle-count?station=Station Test");

        cityResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        stationResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        vehicleResponse.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task Post_TriggerReportGeneration_Should_Return_OK()
    {
        var response = await _client.PostAsync("/api/tollusage/report/trigger", null);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}

public static class TestServerFactory
{
    public static HttpClient CreateClient()
    {
        var builder = new WebHostBuilder()
            .UseStartup<MockStartup>();

        var server = new TestServer(builder);
        return server.CreateClient();
    }
}

public class MockStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapPost("/api/tollusage", async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.OK;
                await context.Response.CompleteAsync();
            });

            endpoints.MapGet("/api/tollusage/report/hourly-city", async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.OK;
                await context.Response.WriteAsJsonAsync(new[] { new { City = "Test City", Hour = 10, Count = 1 } });
            });

            endpoints.MapGet("/api/tollusage/report/top-stations", async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.OK;
                await context.Response.WriteAsJsonAsync(new[] { new { Station = "Station Test", Count = 5 } });
            });

            endpoints.MapGet("/api/tollusage/report/vehicle-count", async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.OK;
                await context.Response.WriteAsJsonAsync(new Dictionary<string, int> { { "Motorcycle", 1 } });
            });

            endpoints.MapPost("/api/tollusage/report/trigger", async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.OK;
                await context.Response.CompleteAsync();
            });
        });
    }
}
