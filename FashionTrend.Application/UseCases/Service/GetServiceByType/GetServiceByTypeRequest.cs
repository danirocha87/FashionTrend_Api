using MediatR;

public sealed record GetServiceByTypeRequest(RequestType Type) : 
                   IRequest<List<GetServiceByTypeResponse>>;
