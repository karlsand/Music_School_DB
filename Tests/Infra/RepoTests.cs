using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;
using Music_School_DB.Infra;

namespace Music_School_DB.Tests.Infra
{
    [TestClass] public class RepoTests : AbstractClassTests
    {
        private class testClass : Repo<Student, StudentData>
        {
            public testClass(DbContext? c, DbSet<StudentData>? s) : base(c, s) { }
            protected override Student toDomain(StudentData d) => new(d);
        }
        protected override object createObj() => new testClass(null, null);
    }
}
