using FluentValidation;


public class GetServiceByTypeValidator : AbstractValidator<GetServiceByTypeRequest>
{
    public GetServiceByTypeValidator()
    {
        RuleFor(x => x.Type).NotEmpty();
    }
}
