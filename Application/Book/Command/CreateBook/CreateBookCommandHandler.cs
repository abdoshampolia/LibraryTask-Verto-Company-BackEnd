using Context.DBContext;
using MediatR;

namespace Application.Book.Command.CreateBook
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, Unit>
    {
        private readonly VertoDBContext _vertoDBContext;

        public CreateBookCommandHandler(VertoDBContext vertoDBContext)
        {
            _vertoDBContext = vertoDBContext;
        }

        public async Task<Unit> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var book = new Domain.Entities.Book(request.ISBN, request.BookName, request.AutherName, request.BublishDate, request.Count, request.IsActive);
                await _vertoDBContext.Books!.AddAsync(book);
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
