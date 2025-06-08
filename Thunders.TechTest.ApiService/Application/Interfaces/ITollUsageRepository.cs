using Thunders.TechTest.ApiService.Domain.Entities;

namespace Thunders.TechTest.ApiService.Application.Interfaces;

public interface ITollUsageRepository
{
    Task AddAsync(TollUsage usage, CancellationToken cancellationToken = default);
}
