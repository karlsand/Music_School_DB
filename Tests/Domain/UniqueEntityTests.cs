using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain;

namespace Music_School_DB.Tests.Domain
{
    [TestClass]
    public class UniqueEntityTests : AbstractClassTests<UniqueEntity<CountryData>, UniqueEntity>
    {
        private class testClass : UniqueEntity<CountryData> { }
        protected override UniqueEntity<CountryData> createObj() => new testClass();
        [TestMethod] public void DataTest() => isInconclusive();
        [TestMethod] public void IDTest() => isInconclusive();
        [TestMethod] public void DefaultStringTest() => isInconclusive();
    }
}
