using AutoMapper;

public sealed class GetAllServiceOrderMapper : Profile
{
    public GetAllServiceOrderMapper()
    {
        CreateMap<ServiceOrder, GetAllServiceOrderResponse>();
    }
}
