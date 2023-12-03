using FluentValidation;


public class GetSupplierByIdValidator : AbstractValidator<GetSupplierByIdRequest>
{
    public GetSupplierByIdValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
