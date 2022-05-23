using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Tests.Domain.Party
{
    [TestClass] public class InstrumentTests : SealedClassTests<Instrument, UniqueEntity<InstrumentData>>
    {
        [TestMethod] public void InstrumentNameTest() => isInconclusive();
        [TestMethod] public void ClassificationTest() => isInconclusive();
    }
}
