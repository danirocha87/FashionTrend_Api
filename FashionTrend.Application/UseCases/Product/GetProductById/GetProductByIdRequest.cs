using MediatR;

public sealed record GetProductByIdRequest(Guid Id)
                  : IRequest<GetProductByIdResponse>;
