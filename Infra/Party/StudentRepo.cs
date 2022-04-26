using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Infra.Party
{
    public class StudentRepo : Repo<Student, StudentData>, IStudentRepo
    {
        public StudentRepo(MSDb? db) : base(db, db?.Students) { }
        protected override Student toDomain(StudentData d) => new(d);
        internal override IQueryable<StudentData> addFilter(IQueryable<StudentData> q)
        {
            var y = CurrentFilter;
            if(string.IsNullOrWhiteSpace(y)) return q;
            return q.Where(
                x => x.ID.Contains(y)
                || x.InstrumentID.Contains(y)
                || x.InstructorID.Contains(y)
                || x.FirstName.Contains(y)
                || x.LastName.Contains(y)
                || x.PhoneNr.Contains(y)
                || x.Email.Contains(y));
        }
    }
}
