using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Infra.Party
{
    public class InstructorsRepo : Repo<Instructor, InstructorData>, IInstructorsRepo
    {
        public InstructorsRepo(MSDb? db) : base(db, db?.Instructors) { }
        protected override Instructor toDomain(InstructorData d) => new(d);
    }
}
