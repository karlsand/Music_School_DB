using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Infra.Party
{
    public class InstructorsRepo : Repo<Instructor, InstructorData>, IInstructorsRepo
    {
        public InstructorsRepo(MSDb? db) : base(db, db?.Instructors) { }
        protected override Instructor toDomain(InstructorData d) => new(d);
        internal override IQueryable<InstructorData> addFilter(IQueryable<InstructorData> q)
        {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q
                : q.Where(
                x => contains(x.ID, y)
                || contains(x.InstrumentID, y)
                || contains(x.FirstName, y)
                || contains(x.LastName, y)
                || contains(x.PhoneNr, y)
                || contains(x.Email, y)
                || contains(x.CoBID, y));
        }
    }
}
