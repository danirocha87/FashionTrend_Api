using AutoMapper;
using MediatR;


public sealed class GetProductByIdHandler : IRequestHandler<GetProductByIdRequest, GetProductByIdResponse>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductByIdHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<GetProductByIdResponse> Handle(GetProductByIdRequest request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.Get(request.Id, cancellationToken);
        return _mapper.Map<GetProductByIdResponse>(product);
    }
}
