using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain;

namespace Music_School_DB.Tests.Domain
{
    [TestClass] public class NamedEntityTests : AbstractClassTests<NamedEntity<CountryData>, UniqueEntity<CountryData>>
    {
        private class testClass : NamedEntity<CountryData> { }
        protected override NamedEntity<CountryData> createObj() => new testClass();
        [TestMethod] public void CodeTest() => isInconclusive();
        [TestMethod] public void NameTest() => isInconclusive();
        [TestMethod] public void DescriptionTest() => isInconclusive();
    }
}
