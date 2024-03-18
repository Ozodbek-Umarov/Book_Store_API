using Domain.Entities;
using FluentValidation;

namespace Application.Validators;

public class AuthorValidator : AbstractValidator<Author>
{
    public AuthorValidator()
    {
        RuleFor(x => x.FullName).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.ImageUrl).MaximumLength(100).WithMessage("Name can't be longer than 100 characters");
    }   
}
