using Music_School_DB.Data.Party;

namespace Music_School_DB.Domain.Party
{
    public class Instructor
    {
        private const string defaultStr = "Undefined";
        private InstructorData data;
        public Instructor() : this(new InstructorData()) { }
        public Instructor (InstructorData d) => data = d;
        public string ID => data?.ID ?? defaultStr;
        public string InstrumentID => data?.InstrumentID ?? defaultStr;
        public string FirstName => data?.FirstName ?? defaultStr;
        public string LastName => data?.LastName ?? defaultStr;
        public string Email => data?.Email ?? defaultStr;
        public string PhoneNr => data?.PhoneNr ?? defaultStr;
        public InstructorData Data => data;
        public override string ToString() => $"{FirstName} {LastName} ({Email}, {PhoneNr})";
    }
}
