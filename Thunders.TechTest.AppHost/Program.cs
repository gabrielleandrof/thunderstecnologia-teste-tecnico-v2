var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var rabbitMqPassword = builder.AddParameter("RabbitMqPassword", true);
var rabbitMq = builder.AddRabbitMQ("RabbitMq", password: rabbitMqPassword)
    .WithDataVolume()
    .WithVolume("/etc/rabbitmq")
    .WithManagementPlugin();

//comentado para nao utilizar o sql do aspire e sim do docker-compose

//var sqlServerPassword = builder.AddParameter("SqlServerInstancePassword", true);
//var sqlServer = builder.AddSqlServer("SqlServerInstance", sqlServerPassword)
//    .WithDataVolume();

//var database = sqlServer.AddDatabase("ThundersTechTestDb", "TollDb");

var apiService = builder.AddProject<Projects.Thunders_TechTest_ApiService>("apiservice")
    .WithReference(rabbitMq)
    .WaitFor(rabbitMq);

builder.Build().Run();
