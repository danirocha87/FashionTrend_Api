using MediatR;

public sealed record CreateDraftContractRequest(Guid SupplierId, string Description)
    : IRequest<CreateDraftContractResponse>;