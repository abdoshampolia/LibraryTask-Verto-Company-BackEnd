using Domain.Entities;
using DTO.Mappings;


namespace Dto
{
    public class BookDto : IMapFrom<Book>
    {
        public string? ISBN { get; set; }
        public string? BookName { get; set; }
        public string? AutherName { get; set; }
        public DateTimeOffset? BublishDate { get; set; }
        public int? Count { get; set; }
        public bool? IsActive { get; set; }
    }
}
