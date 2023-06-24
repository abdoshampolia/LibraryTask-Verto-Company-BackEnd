using MediatR;
using Context.DBContext;

namespace Application.Student.Command.DeleteStudent
{
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand, Unit>
    {
        private readonly VertoDBContext _vertoDBContext;

        public DeleteStudentCommandHandler(VertoDBContext vertoDBContext)
        {
            _vertoDBContext = vertoDBContext;
        }

        public async Task<Unit> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {

            try
            {
                var student = await _vertoDBContext.Students.FindAsync(request.Id);

                if (student != null)
                {
                    _vertoDBContext.Students.Remove(student);
                    return Unit.Value;
                }
                else
                {
                    throw new Exception();
                }
            }

            catch (Exception ex)
            {
                return Unit.Value;
            }
        }
    }
}
