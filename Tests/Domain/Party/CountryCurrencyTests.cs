using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Tests.Domain.Party
{
    [TestClass] public class CountryCurrencyTests : SealedClassTests<CountryCurrency, NamedEntity<CountryCurrencyData>>
    {
        [TestMethod] public void CountryIDTest() => isInconclusive();
        [TestMethod] public void CurrencyIDTest() => isInconclusive();
        [TestMethod] public void CountryTest() => isInconclusive();
        [TestMethod] public void CurrencyTest() => isInconclusive();
    }
}
