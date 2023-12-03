using AutoMapper;

public sealed class DeleteSupplierMapper : Profile
{
    public DeleteSupplierMapper()
    {
        CreateMap<DeleteSupplierRequest, Supplier>();
        CreateMap<Supplier, DeleteSupplierResponse>();
    }
}
