using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Aids;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Tests.Domain.Party
{
    [TestClass] public class StudentTests : SealedClassTests<Student, UniqueEntity<StudentData>>
    {
        protected override Student createObj() => new(GetRandom.Value<StudentData>());
        [TestMethod] public void InstrumentIDTest() => isReadOnly(obj.Data.InstrumentID);
        [TestMethod] public void InstructorIDTest() => isReadOnly(obj.Data.InstructorID);
        [TestMethod] public void FirstNameTest() => isReadOnly(obj.Data.FirstName);
        [TestMethod] public void LastNameTest() => isReadOnly(obj.Data.LastName);
        [TestMethod] public void EmailTest() => isReadOnly(obj.Data.Email);
        [TestMethod] public void PhoneNrTest() => isReadOnly(obj.Data.PhoneNr);
        [TestMethod] public void CoBIDTest() => isReadOnly(obj.Data.CoBID);
        [TestMethod] public void ToStringTest() => isInconclusive();
        [TestMethod] public void InstructorTest() => isInconclusive();
    }
}
