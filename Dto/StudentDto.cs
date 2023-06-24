using Domain.Entities;
using DTO.Mappings;

namespace Dto
{
    public class StudentDto : IMapFrom<Student>
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int? NationalId { get; set; }
        public string? Email { get; set; }
        public int? MobileNumber { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }
        public bool? IsActive { get; set; }
        public IEnumerable<Book>? Books { get; set; }
    }
}
