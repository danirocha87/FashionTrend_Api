using AutoMapper;
using MediatR;


public sealed class DeleteSupplierHandler : IRequestHandler<DeleteSupplierRequest, DeleteSupplierResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;

    public DeleteSupplierHandler(IUnitOfWork unitOfWork,
                             ISupplierRepository supplierRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _supplierRepository = supplierRepository;
        _mapper = mapper;
    }

    public async Task<DeleteSupplierResponse> Handle(DeleteSupplierRequest request,
                                                 CancellationToken cancellationToken)
    {
        try
        {
            var supplier = await _supplierRepository.Get(request.Id, cancellationToken);

            if (supplier == null) { throw new ArgumentException("Supplier not found"); }

            _supplierRepository.Delete(supplier);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteSupplierResponse>(supplier);
        
        } catch (Exception) { throw; }
    }
}
