using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;
using Music_School_DB.Facade;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Tests.Facade
{
    [TestClass]
    public class BaseViewFactoryTests : AbstractClassTests
    {
        private class testClass : BaseViewFactory<StudentView, Student, StudentData>
        {
            protected override Student toEntity(StudentData d) => new(d);
        }
        protected override object createObj() => new testClass();
    }
}
