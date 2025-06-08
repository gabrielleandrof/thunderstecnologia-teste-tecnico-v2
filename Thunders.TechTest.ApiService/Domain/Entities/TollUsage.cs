using Thunders.TechTest.ApiService.Domain.Enums;

namespace Thunders.TechTest.ApiService.Domain.Entities;

public class TollUsage
{
    public Guid Id { get; set; }
    public DateTime Timestamp { get; set; }
    public string TollStation { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public decimal AmountPaid { get; set; }
    public VehicleType VehicleType { get; set; }

    public TollUsage(
        Guid id,
        DateTime timestamp,
        string tollStation,
        string city,
        string state,
        decimal amount,
        VehicleType vehicleType)
    {
        Id = id;
        Timestamp = timestamp;
        TollStation = tollStation;
        City = city;
        State = state;
        AmountPaid = amount;
        VehicleType = vehicleType;
    }

    public TollUsage() { }
}
