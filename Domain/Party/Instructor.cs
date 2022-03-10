using Music_School_DB.Data.Party;

namespace Music_School_DB.Domain.Party
{
    public class Instructor : Entity<InstructorData>
    {
        private const string defaultStr = "Undefined";
        public Instructor() : this(new InstructorData()) { }
        public Instructor (InstructorData d) : base(d) { }
        public string ID => Data?.ID ?? defaultStr;
        public string InstrumentID => Data?.InstrumentID ?? defaultStr;
        public string FirstName => Data?.FirstName ?? defaultStr;
        public string LastName => Data?.LastName ?? defaultStr;
        public string Email => Data?.Email ?? defaultStr;
        public string PhoneNr => Data?.PhoneNr ?? defaultStr;
        public override string ToString() => $"{FirstName} {LastName} ({Email}, {PhoneNr})";
    }
}
