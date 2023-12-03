using MediatR;

public sealed record CreateServiceRequest(
    string Description,
    RequestType Type,
    Guid ProductId,
    List<SewingMachine> SewingMachines,
    int Quantity,
    double UnitPrice,
    int ServiceDays
    ) : IRequest<CreateServiceResponse>;
