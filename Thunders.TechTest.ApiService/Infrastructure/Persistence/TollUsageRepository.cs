using Microsoft.EntityFrameworkCore;
using Thunders.TechTest.ApiService.Application.Interfaces;
using Thunders.TechTest.ApiService.Domain.Entities;
using Thunders.TechTest.ApiService.Domain.Enums;

namespace Thunders.TechTest.ApiService.Infrastructure.Persistence;

public class TollUsageRepository : ITollUsageRepository
{
    private readonly TollDbContext _context;

    public TollUsageRepository(TollDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(TollUsage tollUsage)
    {
        await _context.TollUsages.AddAsync(tollUsage);
        await _context.SaveChangesAsync();
    }

    public async Task<List<TollUsage>> GetAllAsync()
    {
        return await _context.TollUsages.ToListAsync();
    }

    public async Task<List<(string City, DateTime Hour, decimal Total)>> GetByCityGroupedByHourAsync()
    {
        return await _context.TollUsages
            .GroupBy(t => new { t.City, Hour = new DateTime(t.Timestamp.Year, t.Timestamp.Month, t.Timestamp.Day, t.Timestamp.Hour, 0, 0) })
            .Select(g => new ValueTuple<string, DateTime, decimal>(g.Key.City, g.Key.Hour, g.Sum(x => x.AmountPaid)))
            .ToListAsync();
    }

    public async Task<List<(string TollStation, decimal Total)>> GetTopStationsByMonthAsync(int year, int month, int top)
    {
        var result = await _context.TollUsages
            .Where(t => t.Timestamp.Year == year && t.Timestamp.Month == month)
            .GroupBy(t => t.TollStation)
            .Select(g => new { TollStation = g.Key, Total = g.Sum(x => x.AmountPaid) })
            .OrderByDescending(x => x.Total)
            .Take(top)
            .ToListAsync();

        return result.Select(x => (x.TollStation, x.Total)).ToList();
    }

    public async Task<Dictionary<VehicleType, int>> GetVehicleTypeCountsByStationAsync(string station)
    {
        return await _context.TollUsages
            .Where(t => t.TollStation == station)
            .GroupBy(t => t.VehicleType)
            .Select(g => new { g.Key, Count = g.Count() })
            .ToDictionaryAsync(x => x.Key, x => x.Count);
    }
}
