using Microsoft.EntityFrameworkCore;
using Thunders.TechTest.ApiService.Domain.Entities;
using Thunders.TechTest.ApiService.Domain.Enums;

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
            entity.Property(e => e.AmountPaid).HasPrecision(10, 2);
        });

        modelBuilder.Entity<TollUsage>().HasData(
                    new TollUsage
                    {
                        Id = Guid.Parse("93208d34-5ef6-47e2-bcc9-014a9028c7ac"),
                        Timestamp = new DateTime(2025, 6, 10, 2, 20, 0),
                        TollStation = "Station A",
                        City = "São Paulo",
                        State = "SP",
                        AmountPaid = 13.0m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("cb21d832-f915-4a57-a8d6-07cdf6caa387"),
                        Timestamp = new DateTime(2025, 6, 9, 6, 0, 0),
                        TollStation = "Station D",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 18.25m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("20967d65-f613-446f-87c4-0860bfd4885a"),
                        Timestamp = new DateTime(2025, 5, 29, 6, 9, 51),
                        TollStation = "Station B",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 19.88m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("5feee562-4f61-4308-a10b-08f67b98eb4b"),
                        Timestamp = new DateTime(2025, 6, 9, 3, 10, 0),
                        TollStation = "Station B",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 14.5m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("5160c0d8-3a9b-4d05-a754-0992ff0cd19d"),
                        Timestamp = new DateTime(2025, 6, 9, 22, 0, 0),
                        TollStation = "Station B",
                        City = "Curitiba",
                        State = "PR",
                        AmountPaid = 7.15m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("911f6796-23c5-45ec-b3e3-0b3fb5b96d34"),
                        Timestamp = new DateTime(2025, 6, 8, 20, 9, 51),
                        TollStation = "Station C",
                        City = "São Paulo",
                        State = "SP",
                        AmountPaid = 11.55m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("56c7185a-ccbf-425e-adb8-15f7573e2d62"),
                        Timestamp = new DateTime(2025, 6, 2, 0, 9, 51),
                        TollStation = "Station B",
                        City = "Curitiba",
                        State = "PR",
                        AmountPaid = 13.15m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("b6372a30-7139-423c-bbf6-1b01a8b02e4c"),
                        Timestamp = new DateTime(2025, 6, 9, 4, 30, 0),
                        TollStation = "Station B",
                        City = "São Paulo",
                        State = "SP",
                        AmountPaid = 9.6m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("50ba339c-dd80-4756-8560-25d5cf00cd57"),
                        Timestamp = new DateTime(2025, 6, 9, 3, 0, 0),
                        TollStation = "Station A",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 7.3m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("612302c1-d5c0-46d7-bfd9-263ba69dc4b0"),
                        Timestamp = new DateTime(2025, 5, 17, 3, 9, 51),
                        TollStation = "Station B",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 16.02m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("4564180a-aa48-407b-a020-32a71c4bb7af"),
                        Timestamp = new DateTime(2025, 6, 9, 3, 10, 0),
                        TollStation = "Station B",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 15.0m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("1074a490-a764-42f6-a184-3846473954ad"),
                        Timestamp = new DateTime(2025, 6, 9, 22, 0, 0),
                        TollStation = "Station E",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 6.42m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("ebf9d74b-0c81-4ad6-90d5-38d4edc8e059"),
                        Timestamp = new DateTime(2025, 6, 9, 22, 0, 0),
                        TollStation = "Station B",
                        City = "Curitiba",
                        State = "PR",
                        AmountPaid = 6.26m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("31f06e4a-3183-4c51-9f47-4e51a7027984"),
                        Timestamp = new DateTime(2025, 6, 9, 6, 0, 0),
                        TollStation = "Station D",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 19.88m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("7167c736-6184-476f-860d-4ef6112c4993"),
                        Timestamp = new DateTime(2025, 5, 13, 3, 9, 51),
                        TollStation = "Station B",
                        City = "Belo Horizonte",
                        State = "MG",
                        AmountPaid = 17.8m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("c3f65839-29f3-49e9-bd2a-51236ed62d72"),
                        Timestamp = new DateTime(2025, 6, 9, 9, 0, 0),
                        TollStation = "Station E",
                        City = "Rio de Janeiro",
                        State = "RJ",
                        AmountPaid = 8.2m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("fa2f4d8c-34fe-4c6a-aac3-52700283c891"),
                        Timestamp = new DateTime(2025, 6, 9, 4, 30, 0),
                        TollStation = "Station B",
                        City = "São Paulo",
                        State = "SP",
                        AmountPaid = 12.02m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("362768b1-99ee-4d1a-b718-56b5e90df53f"),
                        Timestamp = new DateTime(2025, 6, 9, 3, 20, 0),
                        TollStation = "Station C",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 15.27m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("452f7376-48e2-49b3-9822-57a6611a01cf"),
                        Timestamp = new DateTime(2025, 5, 19, 19, 9, 51),
                        TollStation = "Station C",
                        City = "Curitiba",
                        State = "PR",
                        AmountPaid = 16.94m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("cc86491a-0c8e-4c7e-81c7-5bdc39301688"),
                        Timestamp = new DateTime(2025, 6, 9, 20, 0, 0),
                        TollStation = "Station C",
                        City = "São Paulo",
                        State = "SP",
                        AmountPaid = 10.1m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("dae2db23-097f-48a3-962e-5cd7120afdff"),
                        Timestamp = new DateTime(2025, 5, 13, 14, 9, 51),
                        TollStation = "Station E",
                        City = "Rio de Janeiro",
                        State = "RJ",
                        AmountPaid = 19.94m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("6c122746-4f09-43f4-8432-5f59a1781216"),
                        Timestamp = new DateTime(2025, 6, 10, 2, 20, 0),
                        TollStation = "Station A",
                        City = "São Paulo",
                        State = "SP",
                        AmountPaid = 15.0m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("44f5b679-2b1f-487d-9985-5f96faadef25"),
                        Timestamp = new DateTime(2025, 6, 9, 3, 0, 0),
                        TollStation = "Station A",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 14.73m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("2e08d854-dd66-436c-8393-5ff418a94639"),
                        Timestamp = new DateTime(2025, 5, 22, 9, 9, 51),
                        TollStation = "Station E",
                        City = "Rio de Janeiro",
                        State = "RJ",
                        AmountPaid = 11.97m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("bfeb34a3-db0a-4b35-b3c5-612de20a4c14"),
                        Timestamp = new DateTime(2025, 6, 9, 3, 0, 0),
                        TollStation = "Station B",
                        City = "Belo Horizonte",
                        State = "MG",
                        AmountPaid = 17.8m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("83da7abc-5da1-4f7a-b770-65e952a9bd1d"),
                        Timestamp = new DateTime(2025, 6, 10, 0, 0, 0),
                        TollStation = "Station B",
                        City = "Curitiba",
                        State = "PR",
                        AmountPaid = 11.8m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("294934e0-01d6-4a21-b6c3-66fdea6787a5"),
                        Timestamp = new DateTime(2025, 5, 11, 4, 9, 51),
                        TollStation = "Station A",
                        City = "Curitiba",
                        State = "PR",
                        AmountPaid = 14.4m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("4ffe3f62-33a5-490d-8aa4-6e8b4bf8e868"),
                        Timestamp = new DateTime(2025, 6, 9, 19, 0, 0),
                        TollStation = "Station C",
                        City = "Curitiba",
                        State = "PR",
                        AmountPaid = 16.75m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("fc6435f0-0cc1-43d4-9886-749604a068c3"),
                        Timestamp = new DateTime(2025, 5, 11, 2, 9, 51),
                        TollStation = "Station C",
                        City = "São Paulo",
                        State = "SP",
                        AmountPaid = 14.99m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("effc7619-8631-4559-ad33-75c97ccf4167"),
                        Timestamp = new DateTime(2025, 6, 9, 3, 0, 0),
                        TollStation = "Station A",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 7.3m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("d4985ee4-999a-46d1-b2d3-86e4df36cef2"),
                        Timestamp = new DateTime(2025, 6, 9, 9, 0, 0),
                        TollStation = "Station E",
                        City = "Rio de Janeiro",
                        State = "RJ",
                        AmountPaid = 11.97m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("f024787b-467d-450c-bc7b-8bcad145ca35"),
                        Timestamp = new DateTime(2025, 6, 9, 20, 0, 0),
                        TollStation = "Station C",
                        City = "São Paulo",
                        State = "SP",
                        AmountPaid = 11.55m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("84872f5c-4449-4bd1-b708-8ee8f1ed3ada"),
                        Timestamp = new DateTime(2025, 6, 9, 4, 0, 0),
                        TollStation = "Station A",
                        City = "Curitiba",
                        State = "PR",
                        AmountPaid = 15.8m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("a88087b1-1da4-41e3-8560-8f6f601e0637"),
                        Timestamp = new DateTime(2025, 6, 10, 0, 0, 0),
                        TollStation = "Station B",
                        City = "Curitiba",
                        State = "PR",
                        AmountPaid = 11.8m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("d4a3bbd7-2658-46b3-b1ff-8f966ae036d6"),
                        Timestamp = new DateTime(2025, 6, 9, 14, 0, 0),
                        TollStation = "Station E",
                        City = "Rio de Janeiro",
                        State = "RJ",
                        AmountPaid = 19.94m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("2ec01705-0601-4d64-8f82-92e2633c4d90"),
                        Timestamp = new DateTime(2025, 6, 10, 0, 0, 0),
                        TollStation = "Station E",
                        City = "Belo Horizonte",
                        State = "MG",
                        AmountPaid = 15.0m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("7c8f2a0c-34f9-418b-be25-97ad66071c0e"),
                        Timestamp = new DateTime(2025, 6, 9, 4, 0, 0),
                        TollStation = "Station A",
                        City = "Curitiba",
                        State = "PR",
                        AmountPaid = 15.8m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("b8f0ff5e-93a0-4626-b479-a29632ddbb6a"),
                        Timestamp = new DateTime(2025, 6, 9, 3, 10, 0),
                        TollStation = "Station B",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 14.5m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("4ffa96be-9325-4ada-974b-a3c36336403d"),
                        Timestamp = new DateTime(2025, 6, 9, 3, 30, 0),
                        TollStation = "Station N",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 19.52m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("2b3dfcf0-4df3-45be-93d6-a82b3d45af93"),
                        Timestamp = new DateTime(2025, 6, 9, 19, 0, 0),
                        TollStation = "Station C",
                        City = "Curitiba",
                        State = "PR",
                        AmountPaid = 16.94m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("60e1f5f5-5050-4eb9-bd14-a851d27f47c9"),
                        Timestamp = new DateTime(2025, 5, 10, 22, 9, 51),
                        TollStation = "Station B",
                        City = "Curitiba",
                        State = "PR",
                        AmountPaid = 6.26m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("8ae2447c-d01e-44bb-a451-a996a1a725c5"),
                        Timestamp = new DateTime(2025, 6, 9, 3, 0, 0),
                        TollStation = "Station B",
                        City = "Belo Horizonte",
                        State = "MG",
                        AmountPaid = 19.9m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("e2c94641-3413-40b3-ad0c-aaa0339002c4"),
                        Timestamp = new DateTime(2025, 6, 9, 22, 0, 0),
                        TollStation = "Station E",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 6.9m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("20d9bf47-bb4c-4bb3-bbf6-ad1744bf96fc"),
                        Timestamp = new DateTime(2025, 5, 16, 22, 9, 51),
                        TollStation = "Station E",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 6.42m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("685dbdb3-2592-4fc6-91e9-ae9d50cf8375"),
                        Timestamp = new DateTime(2025, 6, 9, 14, 0, 0),
                        TollStation = "Station E",
                        City = "Rio de Janeiro",
                        State = "RJ",
                        AmountPaid = 22.1m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("19b4e060-554c-4e06-87aa-b2dd35260c3a"),
                        Timestamp = new DateTime(2025, 6, 9, 19, 0, 0),
                        TollStation = "Station C",
                        City = "Curitiba",
                        State = "PR",
                        AmountPaid = 16.75m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("7e117dac-3634-4374-8f9b-b6098ad51f03"),
                        Timestamp = new DateTime(2025, 6, 10, 0, 0, 0),
                        TollStation = "Station E",
                        City = "Belo Horizonte",
                        State = "MG",
                        AmountPaid = 15.0m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("a48cad7d-ab81-4301-9546-ba8c3cbeb0ea"),
                        Timestamp = new DateTime(2025, 6, 9, 22, 0, 0),
                        TollStation = "Station B",
                        City = "Curitiba",
                        State = "PR",
                        AmountPaid = 7.15m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("e765ba20-eb96-4bdd-8b0e-bd0f844b55cb"),
                        Timestamp = new DateTime(2025, 6, 10, 2, 20, 0),
                        TollStation = "Station A",
                        City = "São Paulo",
                        State = "SP",
                        AmountPaid = 13.0m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("cb48e7eb-d947-47be-ade3-c1dae648271f"),
                        Timestamp = new DateTime(2025, 6, 9, 3, 20, 0),
                        TollStation = "Station C",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 12.47m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("e5a3839f-b077-4309-adc8-c4caebfc0522"),
                        Timestamp = new DateTime(2025, 5, 17, 0, 9, 51),
                        TollStation = "Station E",
                        City = "Belo Horizonte",
                        State = "MG",
                        AmountPaid = 13.11m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("9b8d42e7-c133-43cc-8b8a-c5f85b088ae2"),
                        Timestamp = new DateTime(2025, 6, 9, 4, 30, 0),
                        TollStation = "Station B",
                        City = "São Paulo",
                        State = "SP",
                        AmountPaid = 9.6m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("1a0155c0-c89e-4788-a27c-c69f453e7119"),
                        Timestamp = new DateTime(2025, 5, 15, 4, 9, 51),
                        TollStation = "Station B",
                        City = "São Paulo",
                        State = "SP",
                        AmountPaid = 12.02m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("60f36766-2c6d-4d4c-aeea-d0d5cc555a76"),
                        Timestamp = new DateTime(2025, 6, 9, 20, 0, 0),
                        TollStation = "Station C",
                        City = "São Paulo",
                        State = "SP",
                        AmountPaid = 10.1m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("cb8a7fbf-546c-4319-8704-d3b5a7f62b7c"),
                        Timestamp = new DateTime(2025, 6, 9, 14, 0, 0),
                        TollStation = "Station E",
                        City = "Rio de Janeiro",
                        State = "RJ",
                        AmountPaid = 22.1m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("26a41aec-1604-4780-95f0-d8b038120bf7"),
                        Timestamp = new DateTime(2025, 6, 9, 3, 20, 0),
                        TollStation = "Station C",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 12.47m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("81ed0daf-9b6c-496e-be4b-de1b4ea25b5b"),
                        Timestamp = new DateTime(2025, 6, 10, 2, 0, 0),
                        TollStation = "Station C",
                        City = "São Paulo",
                        State = "SP",
                        AmountPaid = 21.6m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("10ce0df3-53a8-4f25-9bab-e1bfb10e8c58"),
                        Timestamp = new DateTime(2025, 6, 9, 22, 0, 0),
                        TollStation = "Station E",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 6.9m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("daa1776e-5ded-4c69-94ef-e78340566ea1"),
                        Timestamp = new DateTime(2025, 6, 9, 4, 0, 0),
                        TollStation = "Station A",
                        City = "Curitiba",
                        State = "PR",
                        AmountPaid = 14.4m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("9684582f-1ec0-4f3e-a7c5-eb8e9663b797"),
                        Timestamp = new DateTime(2025, 6, 9, 3, 0, 0),
                        TollStation = "Station A",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 20.0m,
                        VehicleType = (VehicleType)2
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("e0ce83d0-02fb-4e6a-96dc-eec849125ce1"),
                        Timestamp = new DateTime(2025, 6, 10, 0, 0, 0),
                        TollStation = "Station E",
                        City = "Belo Horizonte",
                        State = "MG",
                        AmountPaid = 13.11m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("ffcb3a02-41a4-429c-ba54-f0ab3f9b98d5"),
                        Timestamp = new DateTime(2025, 6, 9, 9, 0, 0),
                        TollStation = "Station E",
                        City = "Rio de Janeiro",
                        State = "RJ",
                        AmountPaid = 8.2m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("58f89ec2-5779-487d-9d9a-f4184aeff4ba"),
                        Timestamp = new DateTime(2025, 6, 10, 0, 0, 0),
                        TollStation = "Station B",
                        City = "Curitiba",
                        State = "PR",
                        AmountPaid = 13.15m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("31b42012-af58-48cf-840c-f688caef1040"),
                        Timestamp = new DateTime(2025, 6, 10, 2, 0, 0),
                        TollStation = "Station C",
                        City = "São Paulo",
                        State = "SP",
                        AmountPaid = 19.76m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("c59543ef-cb45-4a20-822f-f7b162e30db6"),
                        Timestamp = new DateTime(2025, 6, 9, 3, 0, 0),
                        TollStation = "Station B",
                        City = "Belo Horizonte",
                        State = "MG",
                        AmountPaid = 19.9m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("f1303fcb-06d8-4659-abc0-f9cf4b06b1b7"),
                        Timestamp = new DateTime(2025, 6, 9, 6, 0, 0),
                        TollStation = "Station D",
                        City = "Campinas",
                        State = "SP",
                        AmountPaid = 18.25m,
                        VehicleType = (VehicleType)3
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("056655a2-11aa-4e9a-9b91-fd02eb6f22da"),
                        Timestamp = new DateTime(2025, 5, 22, 2, 9, 51),
                        TollStation = "Station C",
                        City = "São Paulo",
                        State = "SP",
                        AmountPaid = 19.76m,
                        VehicleType = (VehicleType)1
                    },
                    new TollUsage
                    {
                        Id = Guid.Parse("bbefe647-e94b-4d91-a49c-fe595245c7cd"),
                        Timestamp = new DateTime(2025, 6, 10, 2, 0, 0),
                        TollStation = "Station C",
                        City = "São Paulo",
                        State = "SP",
                        AmountPaid = 21.6m,
                        VehicleType = (VehicleType)1
                    }
                );
    }
}