using Application.Common.Exceptions;
using Context.DBContext;
using MediatR;

namespace Application.Student.Queries.GetStudentDetails
{
    public class GetStudentDetailsQueryHandler : IRequestHandler<GetStudentDetailsQuery, Guid>
    {
        private readonly VertoDBContext _vertoDBContext;
        public GetStudentDetailsQueryHandler(VertoDBContext vertoDBContext)
        {
            _vertoDBContext = vertoDBContext;
        }

        public async Task<Guid> Handle(GetStudentDetailsQuery request, CancellationToken cancellationToken)
        {
            var student = await _vertoDBContext.Students.FindAsync(request.Id);

            if (student == null)
            {
                throw new NotFoundException();
            }
                return student.Id;
        }
    }
}
