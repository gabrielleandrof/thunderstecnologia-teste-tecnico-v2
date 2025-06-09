using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Thunders.TechTest.ApiService.Infrastructure.Persistence
{
    public class TollDbContextFactory : IDesignTimeDbContextFactory<TollDbContext>
    {
        public TollDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json", optional: false)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<TollDbContext>();
            var connectionString = config.GetConnectionString("ThundersTechTestDb");

            optionsBuilder.UseSqlServer(connectionString);

            return new TollDbContext(optionsBuilder.Options);
        }
    }
}
