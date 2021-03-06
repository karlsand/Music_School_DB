using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Tests.Domain.Party
{
    [TestClass] public class CountryTests : SealedClassTests<Country, NamedEntity<CountryData>>
    {
        [TestMethod] public void CountryCurrenciesTest() => isInconclusive();
        [TestMethod] public void CurrenciesTest() => isInconclusive();
    }
}
