using AutoMapper;
using MediatR;


public sealed class GetSupplierByEmailHandler : IRequestHandler<GetSupplierByEmailRequest, GetSupplierByEmailResponse>
{
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;

    public GetSupplierByEmailHandler(ISupplierRepository supplierRepository, IMapper mapper)
    {
        _supplierRepository = supplierRepository;
        _mapper = mapper;
    }

    public async Task<GetSupplierByEmailResponse> Handle(GetSupplierByEmailRequest request, CancellationToken cancellationToken)
    {   
        var supplier = await _supplierRepository.GetByEmail(request.Email, cancellationToken);
        if (supplier != null && request.Password != supplier.Password) { return null; }

        return _mapper.Map<GetSupplierByEmailResponse>(supplier);
    }
}
