using Microsoft.EntityFrameworkCore;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Infra.Party
{
    public class InstructorsRepo : Repo<Instructor, InstructorData>, IInstructorsRepo
    {
        public InstructorsRepo(DbContext c, DbSet<InstructorData> s) : base(c, s) { }
        protected override Instructor toDomain(InstructorData d) => new Instructor(d);
    }
}
