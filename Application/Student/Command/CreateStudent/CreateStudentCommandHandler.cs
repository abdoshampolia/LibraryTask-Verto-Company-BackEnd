using Context.DBContext;
using MediatR;

namespace Application.Student.Command.CreateStudent
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Unit>
    {
        private readonly VertoDBContext _vertoDBContext;

        public CreateStudentCommandHandler(VertoDBContext vertoDBContext)
        {
           _vertoDBContext = vertoDBContext;
        }

        public async Task<Unit> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var student = new Domain.Entities.Student(request.Name, request.Address, request.NationalId,
                    request.Email, request.MobileNumber, request.DateOfBirth, request.IsActive);
                await _vertoDBContext.Students.AddAsync(student);
                await _vertoDBContext.SaveChangesAsync();
                return Unit.Value;
            }
            catch (Exception ex)
            {
                return Unit.Value;
            }
        }
    }
}
