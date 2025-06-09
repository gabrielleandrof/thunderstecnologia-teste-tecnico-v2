using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Thunders.TechTest.ApiService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedTollUsageData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TollUsages",
                columns: new[] { "Id", "AmountPaid", "City", "State", "Timestamp", "TollStation", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("056655a2-11aa-4e9a-9b91-fd02eb6f22da"), 19.76m, "São Paulo", "SP", new DateTime(2025, 5, 22, 2, 9, 51, 0, DateTimeKind.Unspecified), "Station C", 1 },
                    { new Guid("1074a490-a764-42f6-a184-3846473954ad"), 6.42m, "Campinas", "SP", new DateTime(2025, 6, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), "Station E", 3 },
                    { new Guid("10ce0df3-53a8-4f25-9bab-e1bfb10e8c58"), 6.9m, "Campinas", "SP", new DateTime(2025, 6, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), "Station E", 3 },
                    { new Guid("19b4e060-554c-4e06-87aa-b2dd35260c3a"), 16.75m, "Curitiba", "PR", new DateTime(2025, 6, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), "Station C", 2 },
                    { new Guid("1a0155c0-c89e-4788-a27c-c69f453e7119"), 12.02m, "São Paulo", "SP", new DateTime(2025, 5, 15, 4, 9, 51, 0, DateTimeKind.Unspecified), "Station B", 3 },
                    { new Guid("20967d65-f613-446f-87c4-0860bfd4885a"), 19.88m, "Campinas", "SP", new DateTime(2025, 5, 29, 6, 9, 51, 0, DateTimeKind.Unspecified), "Station B", 3 },
                    { new Guid("20d9bf47-bb4c-4bb3-bbf6-ad1744bf96fc"), 6.42m, "Campinas", "SP", new DateTime(2025, 5, 16, 22, 9, 51, 0, DateTimeKind.Unspecified), "Station E", 3 },
                    { new Guid("26a41aec-1604-4780-95f0-d8b038120bf7"), 12.47m, "Campinas", "SP", new DateTime(2025, 6, 9, 3, 20, 0, 0, DateTimeKind.Unspecified), "Station C", 1 },
                    { new Guid("294934e0-01d6-4a21-b6c3-66fdea6787a5"), 14.4m, "Curitiba", "PR", new DateTime(2025, 5, 11, 4, 9, 51, 0, DateTimeKind.Unspecified), "Station A", 3 },
                    { new Guid("2b3dfcf0-4df3-45be-93d6-a82b3d45af93"), 16.94m, "Curitiba", "PR", new DateTime(2025, 6, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), "Station C", 2 },
                    { new Guid("2e08d854-dd66-436c-8393-5ff418a94639"), 11.97m, "Rio de Janeiro", "RJ", new DateTime(2025, 5, 22, 9, 9, 51, 0, DateTimeKind.Unspecified), "Station E", 1 },
                    { new Guid("2ec01705-0601-4d64-8f82-92e2633c4d90"), 15.0m, "Belo Horizonte", "MG", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Station E", 1 },
                    { new Guid("31b42012-af58-48cf-840c-f688caef1040"), 19.76m, "São Paulo", "SP", new DateTime(2025, 6, 10, 2, 0, 0, 0, DateTimeKind.Unspecified), "Station C", 1 },
                    { new Guid("31f06e4a-3183-4c51-9f47-4e51a7027984"), 19.88m, "Campinas", "SP", new DateTime(2025, 6, 9, 6, 0, 0, 0, DateTimeKind.Unspecified), "Station D", 3 },
                    { new Guid("362768b1-99ee-4d1a-b718-56b5e90df53f"), 15.27m, "Campinas", "SP", new DateTime(2025, 6, 9, 3, 20, 0, 0, DateTimeKind.Unspecified), "Station C", 1 },
                    { new Guid("44f5b679-2b1f-487d-9985-5f96faadef25"), 14.73m, "Campinas", "SP", new DateTime(2025, 6, 9, 3, 0, 0, 0, DateTimeKind.Unspecified), "Station A", 2 },
                    { new Guid("452f7376-48e2-49b3-9822-57a6611a01cf"), 16.94m, "Curitiba", "PR", new DateTime(2025, 5, 19, 19, 9, 51, 0, DateTimeKind.Unspecified), "Station C", 2 },
                    { new Guid("4564180a-aa48-407b-a020-32a71c4bb7af"), 15.0m, "Campinas", "SP", new DateTime(2025, 6, 9, 3, 10, 0, 0, DateTimeKind.Unspecified), "Station B", 2 },
                    { new Guid("4ffa96be-9325-4ada-974b-a3c36336403d"), 19.52m, "Campinas", "SP", new DateTime(2025, 6, 9, 3, 30, 0, 0, DateTimeKind.Unspecified), "Station N", 2 },
                    { new Guid("4ffe3f62-33a5-490d-8aa4-6e8b4bf8e868"), 16.75m, "Curitiba", "PR", new DateTime(2025, 6, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), "Station C", 2 },
                    { new Guid("50ba339c-dd80-4756-8560-25d5cf00cd57"), 7.3m, "Campinas", "SP", new DateTime(2025, 6, 9, 3, 0, 0, 0, DateTimeKind.Unspecified), "Station A", 2 },
                    { new Guid("5160c0d8-3a9b-4d05-a754-0992ff0cd19d"), 7.15m, "Curitiba", "PR", new DateTime(2025, 6, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), "Station B", 2 },
                    { new Guid("56c7185a-ccbf-425e-adb8-15f7573e2d62"), 13.15m, "Curitiba", "PR", new DateTime(2025, 6, 2, 0, 9, 51, 0, DateTimeKind.Unspecified), "Station B", 1 },
                    { new Guid("58f89ec2-5779-487d-9d9a-f4184aeff4ba"), 13.15m, "Curitiba", "PR", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Station B", 1 },
                    { new Guid("5feee562-4f61-4308-a10b-08f67b98eb4b"), 14.5m, "Campinas", "SP", new DateTime(2025, 6, 9, 3, 10, 0, 0, DateTimeKind.Unspecified), "Station B", 2 },
                    { new Guid("60e1f5f5-5050-4eb9-bd14-a851d27f47c9"), 6.26m, "Curitiba", "PR", new DateTime(2025, 5, 10, 22, 9, 51, 0, DateTimeKind.Unspecified), "Station B", 2 },
                    { new Guid("60f36766-2c6d-4d4c-aeea-d0d5cc555a76"), 10.1m, "São Paulo", "SP", new DateTime(2025, 6, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), "Station C", 2 },
                    { new Guid("612302c1-d5c0-46d7-bfd9-263ba69dc4b0"), 16.02m, "Campinas", "SP", new DateTime(2025, 5, 17, 3, 9, 51, 0, DateTimeKind.Unspecified), "Station B", 3 },
                    { new Guid("685dbdb3-2592-4fc6-91e9-ae9d50cf8375"), 22.1m, "Rio de Janeiro", "RJ", new DateTime(2025, 6, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), "Station E", 2 },
                    { new Guid("6c122746-4f09-43f4-8432-5f59a1781216"), 15.0m, "São Paulo", "SP", new DateTime(2025, 6, 10, 2, 20, 0, 0, DateTimeKind.Unspecified), "Station A", 2 },
                    { new Guid("7167c736-6184-476f-860d-4ef6112c4993"), 17.8m, "Belo Horizonte", "MG", new DateTime(2025, 5, 13, 3, 9, 51, 0, DateTimeKind.Unspecified), "Station B", 3 },
                    { new Guid("7c8f2a0c-34f9-418b-be25-97ad66071c0e"), 15.8m, "Curitiba", "PR", new DateTime(2025, 6, 9, 4, 0, 0, 0, DateTimeKind.Unspecified), "Station A", 3 },
                    { new Guid("7e117dac-3634-4374-8f9b-b6098ad51f03"), 15.0m, "Belo Horizonte", "MG", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Station E", 1 },
                    { new Guid("81ed0daf-9b6c-496e-be4b-de1b4ea25b5b"), 21.6m, "São Paulo", "SP", new DateTime(2025, 6, 10, 2, 0, 0, 0, DateTimeKind.Unspecified), "Station C", 1 },
                    { new Guid("83da7abc-5da1-4f7a-b770-65e952a9bd1d"), 11.8m, "Curitiba", "PR", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Station B", 1 },
                    { new Guid("84872f5c-4449-4bd1-b708-8ee8f1ed3ada"), 15.8m, "Curitiba", "PR", new DateTime(2025, 6, 9, 4, 0, 0, 0, DateTimeKind.Unspecified), "Station A", 3 },
                    { new Guid("8ae2447c-d01e-44bb-a451-a996a1a725c5"), 19.9m, "Belo Horizonte", "MG", new DateTime(2025, 6, 9, 3, 0, 0, 0, DateTimeKind.Unspecified), "Station B", 3 },
                    { new Guid("911f6796-23c5-45ec-b3e3-0b3fb5b96d34"), 11.55m, "São Paulo", "SP", new DateTime(2025, 6, 8, 20, 9, 51, 0, DateTimeKind.Unspecified), "Station C", 2 },
                    { new Guid("93208d34-5ef6-47e2-bcc9-014a9028c7ac"), 13.0m, "São Paulo", "SP", new DateTime(2025, 6, 10, 2, 20, 0, 0, DateTimeKind.Unspecified), "Station A", 2 },
                    { new Guid("9684582f-1ec0-4f3e-a7c5-eb8e9663b797"), 20.0m, "Campinas", "SP", new DateTime(2025, 6, 9, 3, 0, 0, 0, DateTimeKind.Unspecified), "Station A", 2 },
                    { new Guid("9b8d42e7-c133-43cc-8b8a-c5f85b088ae2"), 9.6m, "São Paulo", "SP", new DateTime(2025, 6, 9, 4, 30, 0, 0, DateTimeKind.Unspecified), "Station B", 2 },
                    { new Guid("a48cad7d-ab81-4301-9546-ba8c3cbeb0ea"), 7.15m, "Curitiba", "PR", new DateTime(2025, 6, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), "Station B", 2 },
                    { new Guid("a88087b1-1da4-41e3-8560-8f6f601e0637"), 11.8m, "Curitiba", "PR", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Station B", 1 },
                    { new Guid("b6372a30-7139-423c-bbf6-1b01a8b02e4c"), 9.6m, "São Paulo", "SP", new DateTime(2025, 6, 9, 4, 30, 0, 0, DateTimeKind.Unspecified), "Station B", 2 },
                    { new Guid("b8f0ff5e-93a0-4626-b479-a29632ddbb6a"), 14.5m, "Campinas", "SP", new DateTime(2025, 6, 9, 3, 10, 0, 0, DateTimeKind.Unspecified), "Station B", 2 },
                    { new Guid("bbefe647-e94b-4d91-a49c-fe595245c7cd"), 21.6m, "São Paulo", "SP", new DateTime(2025, 6, 10, 2, 0, 0, 0, DateTimeKind.Unspecified), "Station C", 1 },
                    { new Guid("bfeb34a3-db0a-4b35-b3c5-612de20a4c14"), 17.8m, "Belo Horizonte", "MG", new DateTime(2025, 6, 9, 3, 0, 0, 0, DateTimeKind.Unspecified), "Station B", 3 },
                    { new Guid("c3f65839-29f3-49e9-bd2a-51236ed62d72"), 8.2m, "Rio de Janeiro", "RJ", new DateTime(2025, 6, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), "Station E", 1 },
                    { new Guid("c59543ef-cb45-4a20-822f-f7b162e30db6"), 19.9m, "Belo Horizonte", "MG", new DateTime(2025, 6, 9, 3, 0, 0, 0, DateTimeKind.Unspecified), "Station B", 3 },
                    { new Guid("cb21d832-f915-4a57-a8d6-07cdf6caa387"), 18.25m, "Campinas", "SP", new DateTime(2025, 6, 9, 6, 0, 0, 0, DateTimeKind.Unspecified), "Station D", 3 },
                    { new Guid("cb48e7eb-d947-47be-ade3-c1dae648271f"), 12.47m, "Campinas", "SP", new DateTime(2025, 6, 9, 3, 20, 0, 0, DateTimeKind.Unspecified), "Station C", 1 },
                    { new Guid("cb8a7fbf-546c-4319-8704-d3b5a7f62b7c"), 22.1m, "Rio de Janeiro", "RJ", new DateTime(2025, 6, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), "Station E", 2 },
                    { new Guid("cc86491a-0c8e-4c7e-81c7-5bdc39301688"), 10.1m, "São Paulo", "SP", new DateTime(2025, 6, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), "Station C", 2 },
                    { new Guid("d4985ee4-999a-46d1-b2d3-86e4df36cef2"), 11.97m, "Rio de Janeiro", "RJ", new DateTime(2025, 6, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), "Station E", 1 },
                    { new Guid("d4a3bbd7-2658-46b3-b1ff-8f966ae036d6"), 19.94m, "Rio de Janeiro", "RJ", new DateTime(2025, 6, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), "Station E", 2 },
                    { new Guid("daa1776e-5ded-4c69-94ef-e78340566ea1"), 14.4m, "Curitiba", "PR", new DateTime(2025, 6, 9, 4, 0, 0, 0, DateTimeKind.Unspecified), "Station A", 3 },
                    { new Guid("dae2db23-097f-48a3-962e-5cd7120afdff"), 19.94m, "Rio de Janeiro", "RJ", new DateTime(2025, 5, 13, 14, 9, 51, 0, DateTimeKind.Unspecified), "Station E", 2 },
                    { new Guid("e0ce83d0-02fb-4e6a-96dc-eec849125ce1"), 13.11m, "Belo Horizonte", "MG", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Station E", 1 },
                    { new Guid("e2c94641-3413-40b3-ad0c-aaa0339002c4"), 6.9m, "Campinas", "SP", new DateTime(2025, 6, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), "Station E", 3 },
                    { new Guid("e5a3839f-b077-4309-adc8-c4caebfc0522"), 13.11m, "Belo Horizonte", "MG", new DateTime(2025, 5, 17, 0, 9, 51, 0, DateTimeKind.Unspecified), "Station E", 1 },
                    { new Guid("e765ba20-eb96-4bdd-8b0e-bd0f844b55cb"), 13.0m, "São Paulo", "SP", new DateTime(2025, 6, 10, 2, 20, 0, 0, DateTimeKind.Unspecified), "Station A", 2 },
                    { new Guid("ebf9d74b-0c81-4ad6-90d5-38d4edc8e059"), 6.26m, "Curitiba", "PR", new DateTime(2025, 6, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), "Station B", 2 },
                    { new Guid("effc7619-8631-4559-ad33-75c97ccf4167"), 7.3m, "Campinas", "SP", new DateTime(2025, 6, 9, 3, 0, 0, 0, DateTimeKind.Unspecified), "Station A", 2 },
                    { new Guid("f024787b-467d-450c-bc7b-8bcad145ca35"), 11.55m, "São Paulo", "SP", new DateTime(2025, 6, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), "Station C", 2 },
                    { new Guid("f1303fcb-06d8-4659-abc0-f9cf4b06b1b7"), 18.25m, "Campinas", "SP", new DateTime(2025, 6, 9, 6, 0, 0, 0, DateTimeKind.Unspecified), "Station D", 3 },
                    { new Guid("fa2f4d8c-34fe-4c6a-aac3-52700283c891"), 12.02m, "São Paulo", "SP", new DateTime(2025, 6, 9, 4, 30, 0, 0, DateTimeKind.Unspecified), "Station B", 2 },
                    { new Guid("fc6435f0-0cc1-43d4-9886-749604a068c3"), 14.99m, "São Paulo", "SP", new DateTime(2025, 5, 11, 2, 9, 51, 0, DateTimeKind.Unspecified), "Station C", 1 },
                    { new Guid("ffcb3a02-41a4-429c-ba54-f0ab3f9b98d5"), 8.2m, "Rio de Janeiro", "RJ", new DateTime(2025, 6, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), "Station E", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("056655a2-11aa-4e9a-9b91-fd02eb6f22da"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("1074a490-a764-42f6-a184-3846473954ad"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("10ce0df3-53a8-4f25-9bab-e1bfb10e8c58"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("19b4e060-554c-4e06-87aa-b2dd35260c3a"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("1a0155c0-c89e-4788-a27c-c69f453e7119"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("20967d65-f613-446f-87c4-0860bfd4885a"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("20d9bf47-bb4c-4bb3-bbf6-ad1744bf96fc"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("26a41aec-1604-4780-95f0-d8b038120bf7"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("294934e0-01d6-4a21-b6c3-66fdea6787a5"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("2b3dfcf0-4df3-45be-93d6-a82b3d45af93"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("2e08d854-dd66-436c-8393-5ff418a94639"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("2ec01705-0601-4d64-8f82-92e2633c4d90"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("31b42012-af58-48cf-840c-f688caef1040"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("31f06e4a-3183-4c51-9f47-4e51a7027984"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("362768b1-99ee-4d1a-b718-56b5e90df53f"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("44f5b679-2b1f-487d-9985-5f96faadef25"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("452f7376-48e2-49b3-9822-57a6611a01cf"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("4564180a-aa48-407b-a020-32a71c4bb7af"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("4ffa96be-9325-4ada-974b-a3c36336403d"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("4ffe3f62-33a5-490d-8aa4-6e8b4bf8e868"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("50ba339c-dd80-4756-8560-25d5cf00cd57"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("5160c0d8-3a9b-4d05-a754-0992ff0cd19d"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("56c7185a-ccbf-425e-adb8-15f7573e2d62"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("58f89ec2-5779-487d-9d9a-f4184aeff4ba"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("5feee562-4f61-4308-a10b-08f67b98eb4b"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("60e1f5f5-5050-4eb9-bd14-a851d27f47c9"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("60f36766-2c6d-4d4c-aeea-d0d5cc555a76"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("612302c1-d5c0-46d7-bfd9-263ba69dc4b0"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("685dbdb3-2592-4fc6-91e9-ae9d50cf8375"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("6c122746-4f09-43f4-8432-5f59a1781216"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("7167c736-6184-476f-860d-4ef6112c4993"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("7c8f2a0c-34f9-418b-be25-97ad66071c0e"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("7e117dac-3634-4374-8f9b-b6098ad51f03"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("81ed0daf-9b6c-496e-be4b-de1b4ea25b5b"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("83da7abc-5da1-4f7a-b770-65e952a9bd1d"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("84872f5c-4449-4bd1-b708-8ee8f1ed3ada"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("8ae2447c-d01e-44bb-a451-a996a1a725c5"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("911f6796-23c5-45ec-b3e3-0b3fb5b96d34"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("93208d34-5ef6-47e2-bcc9-014a9028c7ac"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("9684582f-1ec0-4f3e-a7c5-eb8e9663b797"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("9b8d42e7-c133-43cc-8b8a-c5f85b088ae2"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("a48cad7d-ab81-4301-9546-ba8c3cbeb0ea"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("a88087b1-1da4-41e3-8560-8f6f601e0637"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("b6372a30-7139-423c-bbf6-1b01a8b02e4c"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("b8f0ff5e-93a0-4626-b479-a29632ddbb6a"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("bbefe647-e94b-4d91-a49c-fe595245c7cd"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("bfeb34a3-db0a-4b35-b3c5-612de20a4c14"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("c3f65839-29f3-49e9-bd2a-51236ed62d72"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("c59543ef-cb45-4a20-822f-f7b162e30db6"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("cb21d832-f915-4a57-a8d6-07cdf6caa387"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("cb48e7eb-d947-47be-ade3-c1dae648271f"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("cb8a7fbf-546c-4319-8704-d3b5a7f62b7c"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("cc86491a-0c8e-4c7e-81c7-5bdc39301688"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("d4985ee4-999a-46d1-b2d3-86e4df36cef2"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("d4a3bbd7-2658-46b3-b1ff-8f966ae036d6"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("daa1776e-5ded-4c69-94ef-e78340566ea1"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("dae2db23-097f-48a3-962e-5cd7120afdff"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("e0ce83d0-02fb-4e6a-96dc-eec849125ce1"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("e2c94641-3413-40b3-ad0c-aaa0339002c4"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("e5a3839f-b077-4309-adc8-c4caebfc0522"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("e765ba20-eb96-4bdd-8b0e-bd0f844b55cb"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("ebf9d74b-0c81-4ad6-90d5-38d4edc8e059"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("effc7619-8631-4559-ad33-75c97ccf4167"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("f024787b-467d-450c-bc7b-8bcad145ca35"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("f1303fcb-06d8-4659-abc0-f9cf4b06b1b7"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("fa2f4d8c-34fe-4c6a-aac3-52700283c891"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("fc6435f0-0cc1-43d4-9886-749604a068c3"));

            migrationBuilder.DeleteData(
                table: "TollUsages",
                keyColumn: "Id",
                keyValue: new Guid("ffcb3a02-41a4-429c-ba54-f0ab3f9b98d5"));
        }
    }
}
