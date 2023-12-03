using AutoMapper;
using MediatR;

public class CreateServiceHandler : IRequestHandler<CreateServiceRequest, CreateServiceResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IServiceRepository _serviceRepository;
    private readonly IMapper _mapper;
    private readonly IProductRepository _productRepository;

    public CreateServiceHandler(IUnitOfWork unitOfWork, IServiceRepository serviceRepository,
        IProductRepository productRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _serviceRepository = serviceRepository;
        _mapper = mapper;
        _productRepository = productRepository;
    }

    public async Task<CreateServiceResponse> Handle(CreateServiceRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var service = _mapper.Map<Service>(request);

            var product = await _productRepository.Get(service.ProductId, cancellationToken);

            if (product is null) { throw new ArgumentException("Product not found"); }

            _serviceRepository.Create(service);

            await _unitOfWork.Commit(cancellationToken);
            return _mapper.Map<CreateServiceResponse>(service);

        } catch (Exception) { throw; }
    }
}