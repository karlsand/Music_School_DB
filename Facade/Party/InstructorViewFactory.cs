using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Facade.Party
{
    public class InstructorViewFactory
    {
        public Instructor Create(InstructorView v) => new(new InstructorData
        {
            ID = v.ID,
            InstrumentID = v.InstrumentID,
            FirstName = v.FirstName,
            LastName = v.LastName,
            Email = v.Email,
            PhoneNr = v.PhoneNr
        });
        public InstructorView Create(Instructor o) => new()
        {
            ID = o.ID,
            InstrumentID = o.InstrumentID,
            FirstName = o.FirstName,
            LastName = o.LastName,
            Email = o.Email,
            PhoneNr = o.PhoneNr,
            FullName = o.ToString()
        };
    }
}
