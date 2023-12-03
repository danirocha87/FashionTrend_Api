using FluentValidation;


public class GetProductByIdValidator : AbstractValidator<GetProductByIdRequest>
{
    public GetProductByIdValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
