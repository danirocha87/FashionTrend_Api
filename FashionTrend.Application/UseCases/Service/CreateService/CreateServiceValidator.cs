using FluentValidation;

public sealed class CreateServiceValidator : AbstractValidator<CreateServiceRequest>
{
    public CreateServiceValidator()
    {
        RuleFor(x => x.Type).NotEmpty();
        RuleFor(x => x.ProductId).NotEmpty();
        RuleFor(x => x.Quantity).NotEmpty();
        RuleFor(x => x.UnitPrice).NotEmpty();
        RuleFor(x => x.ServiceDays).NotEmpty();
        RuleFor(x => x.Description).NotEmpty().MinimumLength(3);
    }
}