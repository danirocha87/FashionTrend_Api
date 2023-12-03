using AutoMapper;
using MediatR;


public sealed class GetAllServiceHandler : IRequestHandler<GetAllServiceRequest, List<GetAllServiceResponse>>
{
    private readonly IServiceRepository _serviceRepository;
    private readonly IMapper _mapper;

    public GetAllServiceHandler(IServiceRepository serviceRepository, IMapper mapper)
    {
        _serviceRepository = serviceRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllServiceResponse>> Handle(GetAllServiceRequest request, CancellationToken cancellationToken)
    {
        var services = await _serviceRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllServiceResponse>>(services);
    }
}
