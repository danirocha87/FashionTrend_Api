using AutoMapper;

public sealed class UpdateProductMapper : Profile
{
    public UpdateProductMapper()
    {
        CreateMap<UpdateProductRequest, Product>();
        CreateMap<Product, UpdateProductResponse>();
    }
}
