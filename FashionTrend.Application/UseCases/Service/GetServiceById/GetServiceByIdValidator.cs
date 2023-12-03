using FluentValidation;


public class GetServiceByIdValidator : AbstractValidator<GetServiceByIdRequest>
{
    public GetServiceByIdValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
