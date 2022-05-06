using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Infra.Party
{
    public class InstructorStudentsRepo : Repo<InstructorStudent, InstructorStudentData>, IInstructorStudentsRepo
    {
        public InstructorStudentsRepo(MSDb? db) : base(db, db?.InstructorStudents) { }
        protected override InstructorStudent toDomain(InstructorStudentData d) => new(d);
        internal override IQueryable<InstructorStudentData> addFilter(IQueryable<InstructorStudentData> q)
        {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q
                : q.Where(
                x => x.ID.Contains(y)
                || x.Code.Contains(y)
                || x.Name.Contains(y)
                || x.InstructorID.Contains(y)
                || x.StudentID.Contains(y));
        }
    }
}
