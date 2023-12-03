using FluentValidation;


public class GetSupplierByEmailValidator : AbstractValidator<GetSupplierByEmailRequest>
{
    public GetSupplierByEmailValidator()
    {
        RuleFor(x => x.Email).NotEmpty();
        RuleFor(x => x.Password).NotEmpty();
    }
}
