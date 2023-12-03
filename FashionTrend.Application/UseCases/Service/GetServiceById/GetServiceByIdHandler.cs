using AutoMapper;
using MediatR;


public sealed class GetServiceByIdHandler : IRequestHandler<GetServiceByIdRequest, GetServiceByIdResponse>
{
    private readonly IServiceRepository _serviceRepository;
    private readonly IMapper _mapper;

    public GetServiceByIdHandler(IServiceRepository serviceRepository, IMapper mapper)
    {
        _serviceRepository = serviceRepository;
        _mapper = mapper;
    }

    public async Task<GetServiceByIdResponse> Handle(GetServiceByIdRequest request, CancellationToken cancellationToken)
    {
        var service = await _serviceRepository.Get(request.Id, cancellationToken);
        return _mapper.Map<GetServiceByIdResponse>(service);
    }
}
