using Microsoft.EntityFrameworkCore;
using Thunders.TechTest.ApiService.Application.Interfaces;
using Thunders.TechTest.ApiService.Infrastructure.Persistence;

namespace Thunders.TechTest.ApiService.DI;

public static class DependencyInjection
{
    public static IServiceCollection AddProjectDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ITollUsageRepository, TollUsageRepository>();

        services.AddDbContext<TollDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ThundersTechTestDb")));

        return services;
    }
}
