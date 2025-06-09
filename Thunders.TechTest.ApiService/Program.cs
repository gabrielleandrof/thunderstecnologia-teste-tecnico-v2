using Thunders.TechTest.ApiService;
using Thunders.TechTest.ApiService.DI;
using Thunders.TechTest.ApiService.Infrastructure.Persistence;
using Thunders.TechTest.OutOfBox.Database;
using Thunders.TechTest.OutOfBox.Queues;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
builder.Services.AddControllers();
builder.Services.AddProjectDependencies(builder.Configuration);

var features = Features.BindFromConfiguration(builder.Configuration);

// Add services to the container.
builder.Services.AddProblemDetails();

if (features.UseMessageBroker)
{
    builder.Services.AddBus(builder.Configuration, new SubscriptionBuilder());
}

if (features.UseEntityFramework)
{
    builder.Services.AddSqlServerDbContext<TollDbContext>(builder.Configuration);
}

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

app.MapDefaultEndpoints();

app.MapControllers();

app.Run();
