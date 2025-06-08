using Thunders.TechTest.ApiService.Application.Interfaces;
using Thunders.TechTest.ApiService.Domain.Entities;

namespace Thunders.TechTest.ApiService.Infrastructure.Persistence;

public class TollUsageRepository : ITollUsageRepository
{
    private readonly TollDbContext _context;

    public TollUsageRepository(TollDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(TollUsage usage, CancellationToken cancellationToken)
    {
        await _context.TollUsages.AddAsync(usage, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
