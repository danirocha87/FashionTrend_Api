using FluentValidation;
public class DeleteProductValidator :
    AbstractValidator<DeleteProductRequest>
{
    public DeleteProductValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
