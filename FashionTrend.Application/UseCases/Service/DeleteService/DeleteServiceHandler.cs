using AutoMapper;
using MediatR;


public sealed class DeleteServiceHandler : IRequestHandler<DeleteServiceRequest, DeleteServiceResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IServiceRepository _serviceRepository;
    private readonly IMapper _mapper;

    public DeleteServiceHandler(IUnitOfWork unitOfWork,
                             IServiceRepository serviceRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _serviceRepository = serviceRepository;
        _mapper = mapper;
    }

    public async Task<DeleteServiceResponse> Handle(DeleteServiceRequest request,
                                                 CancellationToken cancellationToken)
    {
        try
        {
            var service = await _serviceRepository.Get(request.Id, cancellationToken);

            if (service == null) { throw new ArgumentException("Service not found"); }

            _serviceRepository.Delete(service);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteServiceResponse>(service);

        } catch (Exception) { throw; }
    }
}
