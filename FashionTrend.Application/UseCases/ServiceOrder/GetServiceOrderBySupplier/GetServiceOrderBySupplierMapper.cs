using AutoMapper;

public sealed class GetServiceOrderBySupplierMapper : Profile
{
    public GetServiceOrderBySupplierMapper()
    {
        CreateMap<ServiceOrder, GetServiceOrderBySupplierResponse>();
    }
}
