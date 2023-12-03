using MediatR;

public sealed record CreateServiceOrderRequest(
    Guid SupplierId,
    Guid ServiceId,
    DateTime EstimatedDate,
    RequestStatus Status
    ) : IRequest<CreateServiceOrderResponse>;
