using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Infra.Party
{
    public class StudentRepo : Repo<Student, StudentData>, IStudentsRepo
    {
        public StudentRepo(MSDb? db) : base(db, db?.Students) { }
        protected override Student toDomain(StudentData d) => new(d);
        internal override IQueryable<StudentData> addFilter(IQueryable<StudentData> q)
        {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q
                : q.Where(
                x => contains(x.ID, y)
                || contains(x.InstrumentID, y)
                || contains(x.InstructorID, y)
                || contains(x.FirstName, y)
                || contains(x.LastName, y)
                || contains(x.PhoneNr, y)
                || contains(x.Email, y)
                || contains(x.CoBID, y));
        }
    }
}
