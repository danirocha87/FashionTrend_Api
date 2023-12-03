using MediatR;

public sealed record GetAllProductRequest : 
                   IRequest<List<GetAllProductResponse>>;
