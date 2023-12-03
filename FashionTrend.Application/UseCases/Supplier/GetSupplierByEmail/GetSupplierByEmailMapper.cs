using AutoMapper;

public sealed class GetSupplierByEmailMapper : Profile
{
    public GetSupplierByEmailMapper()
    {
        CreateMap<Supplier, GetSupplierByEmailResponse>();
    }
}
