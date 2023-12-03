using AutoMapper;

public sealed class GetAllProductMapper : Profile
{
    public GetAllProductMapper()
    {
        CreateMap<Product, GetAllProductResponse>();
    }
}
