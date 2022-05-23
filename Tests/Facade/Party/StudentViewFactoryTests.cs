using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;
using Music_School_DB.Facade;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Tests.Facade.Party
{
    [TestClass]
    public class StudentViewFactoryTests : SealedClassTests<StudentViewFactory, BaseViewFactory<StudentView, Student, StudentData>>
    {

    }
}
