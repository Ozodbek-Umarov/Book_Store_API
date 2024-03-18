using Domain.Entities;
using FluentValidation;

namespace Application.Validators;

public class BookValidator : AbstractValidator<Book>
{
    public BookValidator()
    {
        RuleFor(x => x.Title).NotEmpty();
        RuleFor(x => x.Author).NotEmpty();
        RuleFor(x => x.Janr).NotEmpty();
    }
}
