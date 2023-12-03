using AutoMapper;

public sealed class DeleteServiceOrderMapper : Profile
{
    public DeleteServiceOrderMapper()
    {
        CreateMap<DeleteServiceOrderRequest, ServiceOrder>();
        CreateMap<ServiceOrder, DeleteServiceOrderResponse>();
    }
}
