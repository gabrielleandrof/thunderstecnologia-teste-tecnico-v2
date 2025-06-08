using MediatR;
using Thunders.TechTest.ApiService.Application.Interfaces;
using Thunders.TechTest.ApiService.Domain.Entities;

namespace Thunders.TechTest.ApiService.Application.Commands.RegisterTollUsage;

public class RegisterTollUsageHandler : IRequestHandler<RegisterTollUsageCommand, Unit>
{
    private readonly ITollUsageRepository _repository;

    public RegisterTollUsageHandler(ITollUsageRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(RegisterTollUsageCommand request, CancellationToken cancellationToken)
    {
        var usage = new TollUsage(
            Guid.NewGuid(),
            request.Timestamp,
            request.TollStation,
            request.City,
            request.State,
            request.AmountPaid,
            request.VehicleType
        );

        await _repository.AddAsync(usage);

        return Unit.Value;
    }
}
