using Application.Common.Mappings;
using Application.Common.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Context.DBContext;
using Dto;
using MediatR;

namespace Application.Book.Queries.FilterBooksPaginated
{
    public class FilterBooksPaginatedQueryHandler : IRequestHandler<FilterBooksPaginatedQuery, PaginatedList<BookDto>>
    {
        private readonly VertoDBContext _vertoDBContext;
        private readonly IMapper _mapper;

        public FilterBooksPaginatedQueryHandler(VertoDBContext vertoDBContext, IMapper mapper)
        {
            _vertoDBContext = vertoDBContext;
            _mapper = mapper;
        }

        public async Task<PaginatedList<BookDto>> Handle(FilterBooksPaginatedQuery request, CancellationToken cancellationToken)
        {
            var books = await _vertoDBContext.Books!
           .Where(x => x.BookName == request.BookName)
           .Where(x => x.AutherName == request.AutherName)
           .OrderBy(x => x.BookName)
           .ProjectTo<BookDto>(_mapper.ConfigurationProvider)
           .PaginatedListAsync(request.PageNumber, request.PageSize);

            return books;
        }
    }
}
