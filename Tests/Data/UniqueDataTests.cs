using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data;

namespace Music_School_DB.Tests.Data
{
    [TestClass] public class UniqueDataTests : AbstractClassTests<UniqueData, object>
    {
        private class testClass : UniqueData { }
        protected override UniqueData createObj() => new testClass();
        [TestMethod] public void NewIDTest()
        {
            isNotNull(UniqueData.NewID);
            areNotEqual(UniqueData.NewID, UniqueData.NewID);
            var pi = typeof(UniqueData).GetProperty(nameof(UniqueData.NewID));
            isFalse(pi?.CanWrite);
        }
        [TestMethod] public void IDTest() => isProperty<string>();
    }
}
