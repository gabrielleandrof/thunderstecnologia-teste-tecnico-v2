using Thunders.TechTest.ApiService.Application.Interfaces;
using Thunders.TechTest.ApiService.Infrastructure.Persistence;

namespace Thunders.TechTest.ApiService.DI;

public static class DependencyInjection
{
    public static IServiceCollection AddProjectDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
        });

        services.AddScoped<ITollUsageRepository, TollUsageRepository>();

        return services;
    }
}
