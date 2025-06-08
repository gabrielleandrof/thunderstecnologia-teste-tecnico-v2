using Thunders.TechTest.ApiService.Domain.Entities;
using Thunders.TechTest.ApiService.Domain.Enums;

namespace Thunders.TechTest.ApiService.Application.Interfaces;

public interface ITollUsageRepository
{
    Task AddAsync(TollUsage tollUsage);
    Task<List<TollUsage>> GetAllAsync();
    Task<List<(string City, DateTime Hour, decimal Total)>> GetByCityGroupedByHourAsync();
    Task<List<(string TollStation, decimal Total)>> GetTopStationsByMonthAsync(int year, int month, int top);
    Task<Dictionary<VehicleType, int>> GetVehicleTypeCountsByStationAsync(string station);
}
