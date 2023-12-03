using AutoMapper;

public sealed class GetProductByIdMapper : Profile
{
    public GetProductByIdMapper()
    {
        CreateMap<Product, GetProductByIdResponse>();
    }
}
