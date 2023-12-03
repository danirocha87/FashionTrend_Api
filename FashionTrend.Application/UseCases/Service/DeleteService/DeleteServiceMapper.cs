using AutoMapper;

public sealed class DeleteServiceMapper : Profile
{
    public DeleteServiceMapper()
    {
        CreateMap<DeleteServiceRequest, Service>();
        CreateMap<Service, DeleteServiceResponse>();
    }
}
