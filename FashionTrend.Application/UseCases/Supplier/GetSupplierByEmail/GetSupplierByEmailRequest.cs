using MediatR;

public sealed record GetSupplierByEmailRequest(string Email, string Password) : 
                   IRequest<GetSupplierByEmailResponse>;
