using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Aids;
using Music_School_DB.Data.Party;

namespace Music_School_DB.Tests.Data.Party
{
    [TestClass] public class IsoGenderDataTests : TypeTests
    {
        [TestMethod] public void NotKnownTest() => doTest(IsoGender.NotKnown, 0, "Not known");
        [TestMethod] public void MaleTest() => doTest(IsoGender.Male, 1, "Male");
        [TestMethod] public void FemaleTest() => doTest(IsoGender.Female, 2, "Female");
        [TestMethod] public void NotApplicableTest() => doTest(IsoGender.NotApplicable, 9, "Not applicable");

        private static void doTest(IsoGender isoGender, int value, string description)
        {
            areEqual(value, (int)isoGender);
            areEqual(description, isoGender.Description());
        }
    }
}
