using MediatR;

public sealed record UpdateServiceOrderRequest(
    Guid Id,
    RequestStatus Status,
    bool Payed
    ) : IRequest<UpdateServiceOrderResponse>;
