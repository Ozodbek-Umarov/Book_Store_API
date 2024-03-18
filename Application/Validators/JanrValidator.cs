using Domain.Entities;
using FluentValidation;

namespace Application.Validators;

public class JanrValidator : AbstractValidator<Janr>
{
    public JanrValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.Name).MaximumLength(100).WithMessage("Name can't be longer than 100 characters");
    }
}
