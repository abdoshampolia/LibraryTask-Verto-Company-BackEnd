using MediatR;

namespace Application.Student.Command.DeleteStudent
{
    public class DeleteStudentCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public DeleteStudentCommand(Guid id)
        {
            Id = id;
        }
    }
}
