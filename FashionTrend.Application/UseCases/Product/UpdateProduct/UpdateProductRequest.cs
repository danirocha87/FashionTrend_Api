using MediatR;

public sealed record UpdateProductRequest(
    Guid Id,
    string Name,
    string Description,
    ClothingType ClothingType,
    List<Material> Materials
    ) : IRequest<UpdateProductResponse>;
