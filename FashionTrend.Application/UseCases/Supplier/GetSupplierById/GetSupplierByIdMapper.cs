using AutoMapper;

public sealed class GetSupplierByIdMapper : Profile
{
    public GetSupplierByIdMapper()
    {
        CreateMap<Supplier, GetSupplierByIdResponse>();
    }
}
