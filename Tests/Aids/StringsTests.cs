using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Aids;

namespace Music_School_DB.Tests.Aids
{
    [TestClass] public class StringsTests : TypeTests
    {
        private string? testStr;

        [TestInitialize] public void Init() => testStr = "1a1b1c.a1b1c1.1d1e1f";
        [TestMethod] public void RemoveTest() => areEqual("abc.abc.def", Strings.Remove(testStr, "1"));
        [TestMethod] public void IsTypeNameTest()
        {
            isFalse(Strings.IsTypeName(testStr));
            var s = Strings.Remove(testStr, "1");
            isFalse(Strings.IsTypeName(s));
            s = Strings.RemoveTail(s);
            isFalse(Strings.IsTypeName(s));
            s = Strings.RemoveTail(s);
            isTrue(Strings.IsTypeName(s));
        }
        [TestMethod] public void IsTypeFullNameTest()
        {
            isTrue(Strings.IsTypeFullName(testStr));
            isTrue(Strings.IsTypeFullName(Strings.Remove(testStr, "1")));
        }
        [TestMethod] public void RemoveTailTest() => areEqual("1a1b1c.a1b1c1", Strings.RemoveTail(testStr));
    }
}
