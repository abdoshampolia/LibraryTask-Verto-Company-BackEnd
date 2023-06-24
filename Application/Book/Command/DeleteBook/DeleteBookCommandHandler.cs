using Context.DBContext;
using MediatR;

namespace Application.Book.Command.DeleteBook
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, Unit>
    {
        private readonly VertoDBContext _vertoDBContext;

        public DeleteBookCommandHandler(VertoDBContext vertoDBContext)
        {
            _vertoDBContext = vertoDBContext;
        }

        public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var book = await _vertoDBContext.Books!.FindAsync(request.Id);

                if (book != null)
                {
                    _vertoDBContext.Books.Remove(book);
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

