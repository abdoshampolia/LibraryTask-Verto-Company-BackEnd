using MediatR;

namespace Application.Book.Command.CreateBook
{
    public class CreateBookCommand : IRequest<Unit>
    {
        public CreateBookCommand(string iSBN, string bookName, string autherName, DateTimeOffset bublishDate, int count, bool isActive)
        {
            ISBN = iSBN;
            BookName = bookName;
            AutherName = autherName;
            BublishDate = bublishDate;
            Count = count;
            IsActive = isActive;
        }

        public string ISBN { get; set; }
        public string BookName { get; set; }
        public string AutherName { get; set; }
        public DateTimeOffset BublishDate { get; set; }
        public int Count { get; set; }
        public bool IsActive { get; set; }
    }
}
