using FluentValidation;
public class DeleteServiceValidator :
    AbstractValidator<DeleteServiceRequest>
{
    public DeleteServiceValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
