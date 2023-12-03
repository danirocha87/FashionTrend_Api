using MediatR;

public sealed record GetSupplierByIdRequest(Guid Id) : 
                   IRequest<GetSupplierByIdResponse>;
