using MediatR;

public sealed record GetServiceOrderByIdRequest(Guid Id) : 
                   IRequest<GetServiceOrderByIdResponse>;
