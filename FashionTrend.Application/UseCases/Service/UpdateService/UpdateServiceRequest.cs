using MediatR;

public sealed record UpdateServiceRequest(
    Guid Id,
    string Description,
    RequestType Type,
    Guid ProductId,
    List<SewingMachine> SewingMachines,
    int Quantity,
    double UnitPrice,
    int ServiceDays
    ) : IRequest<UpdateServiceResponse>;
