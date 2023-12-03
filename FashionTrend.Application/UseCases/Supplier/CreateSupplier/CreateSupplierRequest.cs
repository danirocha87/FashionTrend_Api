using MediatR;

public sealed record CreateSupplierRequest(
    string Email,
    string Name,
    string PhoneNumber,
    string Password,
    List<Material> Materials,
    List<SewingMachine> SewingMachines
    ) : IRequest<CreateSupplierResponse>;
