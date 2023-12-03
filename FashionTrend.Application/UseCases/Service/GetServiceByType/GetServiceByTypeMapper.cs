using AutoMapper;

public sealed class GetServiceByTypeMapper : Profile
{
    public GetServiceByTypeMapper()
    {
        CreateMap<Service, GetServiceByTypeResponse>();
    }
}
