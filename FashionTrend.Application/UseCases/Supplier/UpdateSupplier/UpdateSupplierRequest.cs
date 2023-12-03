using MediatR;

public sealed record UpdateSupplierRequest(
    Guid Id,
    string Email,
    string Name,
    string PhoneNumber,
    string Password,
    List<Material> Materials,
    List<SewingMachine> SewingMachines
    ) : IRequest<UpdateSupplierResponse>;
