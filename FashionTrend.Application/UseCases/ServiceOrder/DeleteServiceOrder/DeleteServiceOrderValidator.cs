using FluentValidation;
public class DeleteServiceOrderValidator :
    AbstractValidator<DeleteServiceOrderRequest>
{
    public DeleteServiceOrderValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
