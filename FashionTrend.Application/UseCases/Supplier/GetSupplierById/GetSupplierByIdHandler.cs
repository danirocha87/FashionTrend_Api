using AutoMapper;
using MediatR;


public sealed class GetSupplierByIdHandler : IRequestHandler<GetSupplierByIdRequest, GetSupplierByIdResponse>
{
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;

    public GetSupplierByIdHandler(ISupplierRepository supplierRepository, IMapper mapper)
    {
        _supplierRepository = supplierRepository;
        _mapper = mapper;
    }

    public async Task<GetSupplierByIdResponse> Handle(GetSupplierByIdRequest request, CancellationToken cancellationToken)
    {
        var supplier = await _supplierRepository.Get(request.Id, cancellationToken);
        return _mapper.Map<GetSupplierByIdResponse>(supplier);
    }
}
