using AutoMapper;
using MediatR;


public sealed class DeleteServiceOrderHandler : IRequestHandler<DeleteServiceOrderRequest, DeleteServiceOrderResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IServiceOrderRepository _serviceOrderRepository;
    private readonly IMapper _mapper;

    public DeleteServiceOrderHandler(IUnitOfWork unitOfWork,
                             IServiceOrderRepository serviceOrderRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _serviceOrderRepository = serviceOrderRepository;
        _mapper = mapper;
    }

    public async Task<DeleteServiceOrderResponse> Handle(DeleteServiceOrderRequest request,
                                                 CancellationToken cancellationToken)
    {
        try
        {
            var serviceOrder = await _serviceOrderRepository.Get(request.Id, cancellationToken);

            if (serviceOrder == null) { throw new ArgumentException("Service Order not found"); }

            _serviceOrderRepository.Delete(serviceOrder);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteServiceOrderResponse>(serviceOrder);
        
        } catch (Exception) { throw; }
    }
}
