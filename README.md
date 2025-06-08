# Thunders Toll System API

RESTful API for registering and reporting toll usage data.

## Technologies
- .NET 8 + Aspire
- MediatR
- Entity Framework Core
- SQL Server
- RabbitMQ (infrastructure-ready)
- Redis (infrastructure-ready)
- Docker Compose

## Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Docker Desktop](https://www.docker.com/products/docker-desktop)

### Running the System

1. Start Docker:
   ```bash
   docker compose up -d
   ```

2. Apply migrations:
   ```bash
   dotnet ef database update \
     --project Thunders.TechTest.ApiService \
     --startup-project Thunders.TechTest.AppHost \
     --context TollDbContext
   ```

3. Run the application:
   ```bash
   dotnet run --project Thunders.TechTest.AppHost
   ```

## API Endpoints

### Register Toll Usage
`POST /api/tollusage`
```json
{
  "timestamp": "2025-06-07T12:30:00Z",
  "tollStation": "Station A",
  "city": "São Paulo",
  "state": "SP",
  "amountPaid": 12.50,
  "vehicleType": 2
}
```

### Report: Hourly by City
`GET /api/tollusage/report/hourly-city`

### Report: Top Toll Stations (Monthly)
`GET /api/tollusage/report/top-stations?year=2025&month=6&top=5`

### Report: Vehicle Count by Station
`GET /api/tollusage/report/vehicle-count?station=Station A`

## Notes
- The infrastructure services (SQL Server, Redis, RabbitMQ, Jaeger) are containerized.
- The application itself must be run locally via AppHost due to Aspire SDK build constraints in Docker.

## Author
Gabriel Ferreira – Full Implementation

---