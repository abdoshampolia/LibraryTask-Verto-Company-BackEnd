using Application.Common.Models;
using Dto;
using MediatR;

namespace Application.Book.Queries.FilterBooksPaginated
{
    public class FilterBooksPaginatedQuery : IRequest<PaginatedList<BookDto>>
    {
        public FilterBooksPaginatedQuery(int pageNumber, int pageSize, string? bookName, string? autherName)
        {
            BookName = bookName;
            AutherName = autherName;
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
        public FilterBooksPaginatedQuery()
        {
        }
        public string? BookName { get; set; }
        public string? AutherName { get; set; }
        public int PageNumber { get; init; } = 1;
        public int PageSize { get; init; } = 10;
    }
}
