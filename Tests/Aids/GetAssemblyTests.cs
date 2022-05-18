using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Aids;

namespace Music_School_DB.Tests.Aids
{
    [TestClass] public class GetAssemblyTests : IsTypeTested
    {
        [TestMethod] public void ByNameTest()
        {
            var n = $"{nameof(Music_School_DB)}.{1}";
            var a = GetAssembly.ByName(nameof(n));
            areEqual(n, a?.FullName);
        }
        [TestMethod] public void OfTypeTest() => isInconclusive();
        [TestMethod] public void TypesTest() => isInconclusive();
        [TestMethod] public void TypeTest() => isInconclusive();
    }
}
