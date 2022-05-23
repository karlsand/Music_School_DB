using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data;
using Music_School_DB.Data.Party;

namespace Music_School_DB.Tests.Data.Party
{
    [TestClass] public class CountryCurrencyDataTests : SealedClassTests<CountryCurrencyData, NamedData>
    {
        [TestMethod] public void CountryIDTest() => isProperty<string>();
        [TestMethod] public void CurrencyIDTest() => isProperty<string>();
    }
}
