using MediatR;

public sealed record GetServiceByIdRequest(Guid Id) : 
                   IRequest<GetServiceByIdResponse>;
