using AutoMapper;

public sealed class UpdateServiceMapper : Profile
{
    public UpdateServiceMapper()
    {
        CreateMap<UpdateServiceRequest, Service>();
        CreateMap<Service, UpdateServiceResponse>();
    }
}
