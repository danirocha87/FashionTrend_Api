using AutoMapper;

public sealed class DeleteProductMapper : Profile
{
    public DeleteProductMapper()
    {
        CreateMap<DeleteProductRequest, Product>();
        CreateMap<Product, DeleteProductResponse>();
    }
}
