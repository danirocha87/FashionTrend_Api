using FluentValidation;

public sealed class CreateServiceOrderValidator : AbstractValidator<CreateServiceOrderRequest>
{
    public CreateServiceOrderValidator()
    {
        RuleFor(x => x.SupplierId).NotEmpty();
        RuleFor(x => x.ServiceId).NotEmpty();

    }
}
