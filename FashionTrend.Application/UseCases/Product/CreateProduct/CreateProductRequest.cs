using MediatR;

public sealed record CreateProductRequest(
    string Name,
    string Description,
    ClothingType ClothingType,
    List<Material> Materials
    ) : IRequest<CreateProductResponse>;
