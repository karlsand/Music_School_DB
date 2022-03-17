using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Music_School_DB.Tests.Music_School_DB
{
    [TestClass] public class IsMSDBTested : IsAssemblyTested
    {
        override protected void isAllTested() => isInconclusive("Namespace has to be changed to \"Music_School_DB.Music_School_DB\"");
    }
}
