using AutoMapper;

public class CreateProductMapper : Profile
{
    public CreateProductMapper()
    {
        CreateMap<CreateProductRequest, Product>();
        CreateMap<Product, CreateProductResponse>();
    }
}