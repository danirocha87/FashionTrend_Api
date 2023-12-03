using FluentValidation;


public class GetServiceOrderByIdValidator : AbstractValidator<GetServiceOrderByIdRequest>
{
    public GetServiceOrderByIdValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
