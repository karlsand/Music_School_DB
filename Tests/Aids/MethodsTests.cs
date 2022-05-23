using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Aids;

namespace Music_School_DB.Tests.Aids
{
    [TestClass] public class MethodsTests : TypeTests
    {
        [TestMethod] public void HasAttributeTest()
        {
            var m = this.GetType().GetMethod(nameof(HasAttributeTest));
            isTrue(Methods.HasAttribute<TestMethodAttribute>(m));
            isFalse(Methods.HasAttribute<TestInitializeAttribute>(m));
        }
    }
}
