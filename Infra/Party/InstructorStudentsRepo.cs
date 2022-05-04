using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Infra.Party
{
    public class InstructorStudentsRepo : Repo<InstructorStudents, InstructorStudentsData>, IInstructorStudentsRepo
    {
        public InstructorStudentsRepo(MSDb? db) : base(db, db?.InstructorStudents) { }
        protected override InstructorStudents toDomain(InstructorStudentsData d) => new(d);
        internal override IQueryable<InstructorStudentsData> addFilter(IQueryable<InstructorStudentsData> q)
        {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q
                : q.Where(
                x => contains(x.ID, y)
                || contains(x.Code, y)
                || contains(x.Name, y)
                || contains(x.InstructorID, y)
                || contains(x.StudentID, y));
        }
    }
}
