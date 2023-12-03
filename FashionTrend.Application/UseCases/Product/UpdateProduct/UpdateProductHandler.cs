using AutoMapper;
using MediatR;

public class UpdateProductHandler : IRequestHandler<UpdateProductRequest, UpdateProductResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public UpdateProductHandler(IUnitOfWork unitOfWork, IProductRepository productRepository,
        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<UpdateProductResponse> Handle(UpdateProductRequest command, CancellationToken cancellationToken)
    {
        try { 
            var product = await _productRepository.Get(command.Id, cancellationToken);

            if (product is null) { throw new ArgumentException("Product not found"); }

            product.Name = command.Name;
            product.Description = command.Description;
            product.ClothingType = command.ClothingType;
            product.Materials = command.Materials;

            _productRepository.Update(product);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateProductResponse>(product);

        } catch (Exception) { throw; }
    }
}
