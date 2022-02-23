using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data.Party;

namespace Music_School_DB.Tests.Data.Party
{
    [TestClass]
    public class InstructorDataTests : BaseTests<InstructorData>
    {
        [TestMethod] public void IDTest() => isProperty<string>();
        [TestMethod] public void InstrumentIDTest() => isProperty<string?>();
        [TestMethod] public void FirstNameTest() => isProperty<string?>();
        [TestMethod] public void LastNameTest() => isProperty<string?>();
        [TestMethod] public void EmailTest() => isProperty<string?>();
        [TestMethod] public void PhoneNrTest() => isProperty<string?>();
    }
}
