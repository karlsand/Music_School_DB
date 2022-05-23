using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Data;
using Music_School_DB.Data.Party;

namespace Music_School_DB.Tests.Data.Party
{
    [TestClass]
    public class InstructorStudentDataTests : SealedClassTests<InstructorStudentData, NamedData>
    {
        [TestMethod] public void InstructorIDTest() => isProperty<string>();
        [TestMethod] public void StudentIDTest() => isProperty<string>();
    }
}
