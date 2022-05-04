using Music_School_DB.Data.Party;

namespace Music_School_DB.Domain.Party
{
    public interface IStudentsRepo : IRepo<Student> { }
    public sealed class Student : UniqueEntity<StudentData>
    {
        public Student() : this(new ()) { }
        public Student(StudentData d) : base(d) { }
        public string InstrumentID => getValue(Data?.InstrumentID);
        public string InstructorID => getValue(Data?.InstructorID);
        public string FirstName => getValue(Data?.FirstName);
        public string LastName => getValue(Data?.LastName);
        public string Email => getValue(Data?.Email);
        public string PhoneNr => getValue(Data?.PhoneNr);
        public string CoBID => getValue(Data?.CoBID);
        public override string ToString() => $"{FirstName} {LastName} ({Email}, {PhoneNr}, {CoBID})";
        public Instructor? Instructor { get; set; }
    }
}
