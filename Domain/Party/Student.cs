using Music_School_DB.Data.Party;

namespace Music_School_DB.Domain.Party
{
    public interface IStudentRepo : IRepo<Student> { }
    public sealed class Student : Entity<StudentData>
    {
        public Student() : this(new StudentData()) { }
        public Student(StudentData d) : base(d) { }
        public string InstrumentID => getValue(Data?.InstrumentID);
        public string InstructorID => getValue(Data?.InstructorID);
        public string FirstName => getValue(Data?.FirstName);
        public string LastName => getValue(Data?.LastName);
        public string Email => getValue(Data?.Email);
        public string PhoneNr => getValue(Data?.PhoneNr);
    }
}
