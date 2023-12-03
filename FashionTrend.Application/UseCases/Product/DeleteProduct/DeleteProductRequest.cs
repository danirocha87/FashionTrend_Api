using MediatR;

public sealed record DeleteProductRequest(Guid Id)
                  : IRequest<DeleteProductResponse>;
