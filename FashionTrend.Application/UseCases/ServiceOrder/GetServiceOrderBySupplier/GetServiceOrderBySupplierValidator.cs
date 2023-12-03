using FluentValidation;


public class GetServiceOrderBySupplierValidator : AbstractValidator<GetServiceOrderBySupplierRequest>
{
    public GetServiceOrderBySupplierValidator()
    {
        RuleFor(x => x.SupplierId).NotEmpty();
    }
}
