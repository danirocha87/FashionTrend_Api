using MediatR;

public sealed record GetServiceOrderBySupplierRequest(Guid SupplierId) : 
                   IRequest<List<GetServiceOrderBySupplierResponse>>;
