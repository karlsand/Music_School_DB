using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Tests.Domain.Party
{
    [TestClass] public class InstructorTests : SealedClassTests<Instructor, UniqueEntity<InstructorData>>
    {
        [TestMethod] public void InstrumentIDTest() => isInconclusive();
        [TestMethod] public void FirstNameTest() => isInconclusive();
        [TestMethod] public void LastNameTest() => isInconclusive();
        [TestMethod] public void EmailTest() => isInconclusive();
        [TestMethod] public void PhoneNrTest() => isInconclusive();
        [TestMethod] public void CoBIDTest() => isInconclusive();
        [TestMethod] public void ToStringTest() => isInconclusive();
        [TestMethod] public void StudentsTest() => isInconclusive();
    }
}
