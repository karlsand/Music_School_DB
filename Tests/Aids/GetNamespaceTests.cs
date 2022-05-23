using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Aids;
using Music_School_DB.Data.Party;

namespace Music_School_DB.Tests.Aids
{
    [TestClass] public class GetNamespaceTests : TypeTests 
    {
        [TestMethod] public void OfTypeTest()
        {
            var obj = new CurrencyData();
            var name = obj.GetType().Namespace;
            var n = GetNamespace.OfType(obj);
            areEqual(name, n);
        }
        [TestMethod] public void OfTypeNullTest()
        {
            CurrencyData? obj = null;
            var n = GetNamespace.OfType(obj);
            areEqual(string.Empty, n);
        }
    }
}
