using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Facade;

namespace Music_School_DB.Tests.Facade
{
    [TestClass]
    public class BaseViewTests : AbstractClassTests
    {
        private class testClass : BaseView { }
        protected override object createObj() => new testClass();
    }
}
