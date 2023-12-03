using AutoMapper;

public sealed class UpdateSupplierMapper : Profile
{
    public UpdateSupplierMapper()
    {
        CreateMap<UpdateSupplierRequest, Supplier>();
        CreateMap<Supplier, UpdateSupplierResponse>();
    }
}
