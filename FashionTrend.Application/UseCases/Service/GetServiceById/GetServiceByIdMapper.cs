using AutoMapper;

public sealed class GetServiceByIdMapper : Profile
{
    public GetServiceByIdMapper()
    {
        CreateMap<Service, GetServiceByIdResponse>();
    }
}
