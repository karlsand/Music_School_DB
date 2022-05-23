using Music_School_DB.Data.Party;

namespace Music_School_DB.Domain.Party
{
    public interface IInstructorsRepo : IRepo<Instructor> { }
    public sealed class Instructor : UniqueEntity<InstructorData>
    {
        public Instructor() : this(new ()) { }
        public Instructor (InstructorData d) : base(d) { }
        public string InstrumentID => getValue(Data?.InstrumentID);
        public string FirstName => getValue(Data?.FirstName);
        public string LastName => getValue(Data?.LastName);
        public string Email => getValue(Data?.Email);
        public string PhoneNr => getValue(Data?.PhoneNr);
        public string CoBID => getValue(Data?.CoBID);
        public override string ToString() => $"{FirstName} {LastName} ({Email}, {PhoneNr})";
        public List<Student>? Students { get; set; }
    }
}
