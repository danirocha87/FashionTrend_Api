using FluentValidation;
public class DeleteSupplierValidator :
    AbstractValidator<DeleteSupplierRequest>
{
    public DeleteSupplierValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
