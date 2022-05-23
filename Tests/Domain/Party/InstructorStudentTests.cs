using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Tests.Domain.Party
{
    [TestClass] public class InstructorStudentTests : SealedClassTests<InstructorStudent, NamedEntity<InstructorStudentData>>
    {
        [TestMethod] public void InstructorIDTest() => isInconclusive();
        [TestMethod] public void StudentIDTest() => isInconclusive();
    }
}
