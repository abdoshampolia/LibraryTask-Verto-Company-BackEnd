using FluentValidation;

namespace Application.Student.Command.CreateStudent
{
    public class CreateStudentCommandValidator : AbstractValidator<CreateStudentCommand>
    {
        public CreateStudentCommandValidator()
        {
            //RuleFor(p => p.Name)
            //    .NotEmpty()
            //    .NotNull()
            //    .MinimumLength(5)
            //    .MaximumLength(50);
            //RuleFor(p => p.Email)
            //   .NotEmpty()
            //   .NotNull()
            //    .MinimumLength(5)
            //    .MaximumLength(50);
        }
    }
}
