using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Music_School_DB.Tests.Soft
{
    [TestClass] public class IsSoftTested : AssemblyTests
    {
        override protected void isAllTested() => isInconclusive("Namespace has to be changed to \"Music_School_DB.Soft\"");
    }
}
