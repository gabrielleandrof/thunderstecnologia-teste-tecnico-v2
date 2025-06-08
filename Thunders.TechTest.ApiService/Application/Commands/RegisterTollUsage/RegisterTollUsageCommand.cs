using Azure.Core;
using MediatR;
using Thunders.TechTest.ApiService.Domain.Enums;

namespace Thunders.TechTest.ApiService.Application.Commands.RegisterTollUsage;

public record RegisterTollUsageCommand(
    DateTime Timestamp,
    string TollStation,
    string City,
    string State,
    decimal AmountPaid,
    VehicleType VehicleType
) : IRequest<Unit>;
