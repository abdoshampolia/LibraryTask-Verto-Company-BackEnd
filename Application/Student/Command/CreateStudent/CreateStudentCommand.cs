using MediatR;

namespace Application.Student.Command.CreateStudent
{
    public class CreateStudentCommand : IRequest<Unit>
    {
        public CreateStudentCommand(string name, string address, int nationalId, string email, int mobileNumber, DateTimeOffset dateOfBirth, bool isActive)
        {
            Name = name;
            Address = address;
            NationalId = nationalId;
            Email = email;
            MobileNumber = mobileNumber;
            DateOfBirth = dateOfBirth;
            IsActive = isActive;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public int NationalId { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public bool IsActive { get; set; }
    }
}
