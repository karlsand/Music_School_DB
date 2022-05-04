using Music_School_DB.Data.Party;

namespace Music_School_DB.Domain.Party
{
    public interface IInstructorStudentsRepo : IRepo<InstructorStudents> { }
    public class InstructorStudents : NamedEntity<InstructorStudentsData>
    {
        public InstructorStudents() : this(new ()) { }
        public InstructorStudents(InstructorStudentsData d) : base(d) { }
        public string InstructorID => getValue(Data?.InstructorID);
        public string StudentID => getValue(Data?.StudentID);
    }
}
