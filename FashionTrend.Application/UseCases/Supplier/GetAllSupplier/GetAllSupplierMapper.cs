using AutoMapper;

public sealed class GetAllSupplierMapper : Profile
{
    public GetAllSupplierMapper()
    {
        CreateMap<Supplier, GetAllSupplierResponse>();
    }
}
