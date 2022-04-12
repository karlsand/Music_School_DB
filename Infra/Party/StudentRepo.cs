using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Infra.Party
{
    public class StudentRepo : Repo<Student, StudentData>, IStudentRepo
    {
        public StudentRepo(MSDb? db) : base(db, db?.Students) { }
        protected override Student toDomain(StudentData d) => new(d);
    }
}
