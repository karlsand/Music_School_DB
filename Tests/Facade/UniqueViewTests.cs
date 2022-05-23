using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Facade;

namespace Music_School_DB.Tests.Facade
{
    [TestClass]
    public class UniqueViewTests : AbstractClassTests<UniqueView, object>
    {
        private class testClass : UniqueView { }
        protected override UniqueView createObj() => new testClass();
    }
}
