using MediatR;

namespace Application.Student.Queries.GetStudentDetails
{
    public class GetStudentDetailsQuery : IRequest<Guid>
    {
        public GetStudentDetailsQuery(Guid id) 
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
