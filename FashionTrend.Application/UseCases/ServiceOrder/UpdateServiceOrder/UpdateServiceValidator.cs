using FluentValidation;


public class UpdateServiceOrderValidator : AbstractValidator<UpdateServiceOrderRequest>
{
    public UpdateServiceOrderValidator()
    {
        RuleFor(x => x.Status).NotEmpty();
    }
}
