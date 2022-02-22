using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Music_School_DB.Tests.Data.Party
{
    [TestClass]
    public class InstructorDataTests : AssertTests
    {
        [TestMethod] public void IDTest() => inconclusive();
        [TestMethod] public void InstrumentIDTest() => inconclusive();
        [TestMethod] public void FirstNameTest() => inconclusive();
        [TestMethod] public void LastNameTest() => inconclusive();
        [TestMethod] public void EmailTest() => inconclusive();
        [TestMethod] public void PhoneNrTest() => inconclusive();
    }

    public class AssertTests
    {
        public void inconclusive() => Assert.Inconclusive();
    }

    public class BaseTests : AssertTests
    {
        public void inconclusive() => Assert.Inconclusive();
    }
}
