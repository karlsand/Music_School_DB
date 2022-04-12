using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Tests.Facade.Party
{
    [TestClass]
    public class StudentViewTests : SealedClassTests<StudentView>
    {
        [TestMethod] public void IDTest() => isProperty<string>();
        [TestMethod] public void InstructorIDTest() => isProperty<string?>();
        [TestMethod] public void InstrumentIDTest() => isProperty<string?>();
        [TestMethod] public void FirstNameTest() => isProperty<string?>();
        [TestMethod] public void LastNameTest() => isProperty<string?>();
        [TestMethod] public void EmailTest() => isProperty<string?>();
        [TestMethod] public void PhoneNrTest() => isProperty<string?>();
    }
}
