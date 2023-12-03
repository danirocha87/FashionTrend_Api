using AutoMapper;

public sealed class UpdateServiceOrderMapper : Profile
{
    public UpdateServiceOrderMapper()
    {
        CreateMap<UpdateServiceOrderRequest, ServiceOrder>();
        CreateMap<ServiceOrder, UpdateServiceOrderResponse>();
    }
}
