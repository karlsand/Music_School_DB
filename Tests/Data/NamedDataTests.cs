using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data;

namespace Music_School_DB.Tests.Data
{
    [TestClass] public class NamedDataTests : AbstractClassTests<NamedData, UniqueData>
    {
        private class testClass : NamedData { }
        protected override NamedData createObj() => new testClass();
        [TestMethod] public void CodeTest() => isProperty<string>();
        [TestMethod] public void NameTest() => isProperty<string?>();
        [TestMethod] public void DescriptionTest() => isProperty<string?>();
    }
}
