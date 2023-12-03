using AutoMapper;

public sealed class GetServiceOrderByIdMapper : Profile
{
    public GetServiceOrderByIdMapper()
    {
        CreateMap<ServiceOrder, GetServiceOrderByIdResponse>();
    }
}
