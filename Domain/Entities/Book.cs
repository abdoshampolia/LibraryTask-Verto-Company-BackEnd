using Domain.Common;

namespace Domain.Entities
{
    public class Book : ModifiableEntity
    {
        public Book(string iSBN, string bookName, string autherName, DateTimeOffset bublishDate, int count, bool isActive)
        {
            ISBN = iSBN;
            BookName = bookName;
            AutherName = autherName;
            BublishDate = bublishDate;
            Count = count;
            IsActive = isActive;
            studnet = new List<Student>();
        }

        public string ISBN { get; set; }
        public string BookName { get; set; }
        public string AutherName { get; set; }
        public DateTimeOffset BublishDate { get; set; }
        public int Count { get; set; }
        public bool IsActive { get; set; }

        private readonly IList<Student> studnet;
        public IEnumerable<Student> Students
        {
            get
            {
                foreach (var studnet in Students) yield return studnet;
            }
        }
    }
}
