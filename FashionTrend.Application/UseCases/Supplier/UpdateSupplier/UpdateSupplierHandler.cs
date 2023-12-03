using AutoMapper;
using MediatR;

public class UpdateSupplierHandler : IRequestHandler<UpdateSupplierRequest, UpdateSupplierResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;

    public UpdateSupplierHandler(IUnitOfWork unitOfWork, ISupplierRepository supplierRepository,
        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _supplierRepository = supplierRepository;
        _mapper = mapper;
    }

    public async Task<UpdateSupplierResponse> Handle(UpdateSupplierRequest command, CancellationToken cancellationToken)
    {
        try
        {
            var supplier = await _supplierRepository.Get(command.Id, cancellationToken);

            if (supplier is null) { throw new ArgumentException("Supplier not found"); }

            supplier.Name = command.Name;
            supplier.Email = command.Email;
            supplier.Password = command.Password;
            supplier.SewingMachines = command.SewingMachines;
            supplier.Materials = command.Materials;
            supplier.PhoneNumber = "+55" + command.PhoneNumber;

            _supplierRepository.Update(supplier);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateSupplierResponse>(supplier);

        } catch (Exception) { throw; }
    }
}
