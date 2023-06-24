using FluentValidation;

namespace Application.Book.Command.CreateBook
{
    public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
    {
        public CreateBookCommandValidator()
        {
            RuleFor(p => p.BookName)
                .NotEmpty()
                .NotNull()
                .MinimumLength(5)
                .MaximumLength(50);
            RuleFor(p => p.AutherName)
               .NotEmpty()
               .NotNull()
                .MinimumLength(5)
                .MaximumLength(50);
        }
    }
}
