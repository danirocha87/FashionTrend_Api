using AutoMapper;
using MediatR;


public sealed class GetServiceByTypeHandler : IRequestHandler<GetServiceByTypeRequest, List<GetServiceByTypeResponse>>
{
    private readonly IServiceRepository _serviceRepository;
    private readonly IMapper _mapper;

    public GetServiceByTypeHandler(IServiceRepository serviceRepository, IMapper mapper)
    {
        _serviceRepository = serviceRepository;
        _mapper = mapper;
    }

    public async Task<List<GetServiceByTypeResponse>> Handle(GetServiceByTypeRequest request, CancellationToken cancellationToken)
    {
        var services = await _serviceRepository.GetByType(request.Type, cancellationToken);
        return _mapper.Map<List<GetServiceByTypeResponse>>(services);
    }
}
