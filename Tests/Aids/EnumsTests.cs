using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Aids;
using Music_School_DB.Data.Party;

namespace Music_School_DB.Tests.Aids
{
    [TestClass] public class EnumsTests : TypeTests
    {
        [TestMethod] public void DescriptionTest() => areEqual("Not applicable", Enums.Description(IsoGender.NotApplicable));
        [TestMethod] public void ToStringTest() => areEqual("Not applicable", IsoGender.NotApplicable.ToString());
    }
}
