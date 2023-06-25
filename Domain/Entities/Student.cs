
using Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class Student : ModifiableEntity
    {
        public Student( string name, string address, int nationalId, string email, int mobileNumber, DateTimeOffset dateOfBirth, bool isActive)
        {
            Name = name;
            Address = address;
            NationalId = nationalId;
            Email = email;
            MobileNumber = mobileNumber;
            DateOfBirth = dateOfBirth;
            IsActive = isActive;
            book = new List<Book>();
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public int NationalId { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public IdentityUser AccountUser { get; set; }

        public bool IsActive { get; set; }
        private readonly IList<Book> book;
        public IEnumerable<Book> Books
        {
            get
            {
                foreach (var book in Books) yield return book;
            }
        }
    }
}
