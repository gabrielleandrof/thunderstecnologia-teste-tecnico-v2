using Microsoft.EntityFrameworkCore;
using Thunders.TechTest.ApiService.Domain.Entities;

namespace Thunders.TechTest.ApiService.Infrastructure.Persistence;

public class TollDbContext : DbContext
{
    public TollDbContext(DbContextOptions<TollDbContext> options) : base(options) { }

    public DbSet<TollUsage> TollUsages => Set<TollUsage>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TollUsage>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.TollStation).IsRequired();
            entity.Property(e => e.City).IsRequired();
            entity.Property(e => e.State).IsRequired();
            entity.Property(e => e.Amount).HasPrecision(10, 2);
        });
    }
}
