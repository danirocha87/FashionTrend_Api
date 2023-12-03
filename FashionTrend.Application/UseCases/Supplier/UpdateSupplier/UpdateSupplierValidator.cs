﻿using FluentValidation;


public class UpdateSupplierValidator : AbstractValidator<UpdateSupplierRequest>
{
    public UpdateSupplierValidator()
    {
        RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
        RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.Password).NotEmpty().MinimumLength(6);
        RuleFor(x => x.PhoneNumber).NotEmpty().Length(11);
    }
}
