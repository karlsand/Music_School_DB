using Music_School_DB.Data.Party;

namespace Music_School_DB.Domain.Party
{
    public interface IInstructorStudentsRepo : IRepo<InstructorStudent> { }
    public class InstructorStudent : NamedEntity<InstructorStudentData>
    {
        public InstructorStudent() : this(new ()) { }
        public InstructorStudent(InstructorStudentData d) : base(d) { }
        public string InstructorID => getValue(Data?.InstructorID);
        public string StudentID => getValue(Data?.StudentID);
    }
}
