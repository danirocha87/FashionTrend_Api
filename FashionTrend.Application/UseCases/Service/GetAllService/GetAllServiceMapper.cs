using AutoMapper;

public sealed class GetAllServiceMapper : Profile
{
    public GetAllServiceMapper()
    {
        CreateMap<Service, GetAllServiceResponse>();
    }
}
