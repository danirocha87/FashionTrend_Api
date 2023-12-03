using AutoMapper;
using MediatR;


public sealed class GetServiceOrderBySupplierHandler : IRequestHandler<GetServiceOrderBySupplierRequest, List<GetServiceOrderBySupplierResponse>>
{
    private readonly IServiceOrderRepository _serviceOrderRepository;
    private readonly IMapper _mapper;

    public GetServiceOrderBySupplierHandler(IServiceOrderRepository serviceOrderRepository, IMapper mapper)
    {
        _serviceOrderRepository = serviceOrderRepository;
        _mapper = mapper;
    }

    public async Task<List<GetServiceOrderBySupplierResponse>> Handle(GetServiceOrderBySupplierRequest request, CancellationToken cancellationToken)
    {
        var serviceOrders = await _serviceOrderRepository.GetBySupplier(request.SupplierId, cancellationToken);
        return _mapper.Map<List<GetServiceOrderBySupplierResponse>>(serviceOrders);
    }
}
