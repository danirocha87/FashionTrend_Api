using FluentValidation;


public class UpdateProductValidator : AbstractValidator<UpdateProductRequest>
{
    public UpdateProductValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Name).NotEmpty().MinimumLength(3);
        RuleFor(x => x.ClothingType).NotEmpty();
    }
}
