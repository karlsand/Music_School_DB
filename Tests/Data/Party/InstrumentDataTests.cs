using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data;
using Music_School_DB.Data.Party;

namespace Music_School_DB.Tests.Data.Party
{
    [TestClass] public class InstrumentDataTests : SealedClassTests<InstrumentData, UniqueData>
    {
        [TestMethod] public void InstrumentNameTest() => isProperty<string?>();
        [TestMethod] public void ClassificationTest() => isProperty<string?>();
    }
}
