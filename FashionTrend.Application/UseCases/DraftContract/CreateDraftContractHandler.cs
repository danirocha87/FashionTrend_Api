using AutoMapper;
using MediatR;
using Microsoft.Extensions.Configuration;

public class CreateDraftContractHandle : IRequestHandler<CreateDraftContractRequest, CreateDraftContractResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDraftContractRepository _repository;
    private readonly IMapper _mapper;
    private readonly ISupplierRepository _supplierRepository;
    private readonly IConfiguration _configuration;
    public CreateDraftContractHandle(IUnitOfWork unitOfWork,
                                    IDraftContractRepository draftContract,
                                    IMapper mapper,
                                    ISupplierRepository supplierRepository,
                                    IConfiguration configuration)
    {
        _mapper = mapper;
        _repository = draftContract;
        _unitOfWork = unitOfWork;
        _supplierRepository = supplierRepository;
        _configuration = configuration;
    }

    public async Task<CreateDraftContractResponse> Handle(CreateDraftContractRequest request, CancellationToken cancellationToken)
    {

        var supplier = await _supplierRepository.Get(request.SupplierId, cancellationToken);
        if (supplier == null) { throw new ArgumentException("Supplier not found"); }

        var draft = _mapper.Map<DraftContract>(request);
        _repository.Create(draft);

        await _unitOfWork.Commit(cancellationToken);

        var builder = new ConfigurationBuilder()
          .AddUserSecrets<CreateNotificationHandler>();
        var userSecretsConfiguration = builder.Build();

        var accountSid = userSecretsConfiguration["Twilio:AccountsID"];
        var authToken = userSecretsConfiguration["Twilio:AuthToken"];
        var twilioPhoneNumber = userSecretsConfiguration["Twilio:TwilioPhoneNumber"];

        var notification = new CreateNotificationHandler(accountSid, authToken, twilioPhoneNumber);

        notification.SendSMS(supplier.PhoneNumber, "Olá, temos uma minuta de contrato disponível para assinatura");

        return _mapper.Map<CreateDraftContractResponse>(draft);

    }
}