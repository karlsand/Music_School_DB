using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data;
using Music_School_DB.Data.Party;

namespace Music_School_DB.Tests.Data.Party
{
    [TestClass] public class StudentDataTests : SealedClassTests<StudentData, UniqueData>
    {
        [TestMethod] public void InstrumentIDTest() => isProperty<string?>();
        [TestMethod] public void InstructorIDTest() => isProperty<string?>();
        [TestMethod] public void FirstNameTest() => isProperty<string?>();
        [TestMethod] public void LastNameTest() => isProperty<string?>();
        [TestMethod] public void EmailTest() => isProperty<string?>();
        [TestMethod] public void PhoneNrTest() => isProperty<string?>();
        [TestMethod] public void CoBIDTest() => isProperty<string?>();
    }
}
