using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Aids;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;
using Music_School_DB.Facade;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Tests.Facade.Party
{
    [TestClass]
    public class InstructorViewFactoryTests : SealedClassTests<InstructorViewFactory, BaseViewFactory<InstructorView, Instructor, InstructorData>>
    {
        [TestMethod] public void CreateTest() { }
        [TestMethod] public void CreateViewTest() 
        {
            var d = GetRandom.Value<InstructorData>();
            var e = new Instructor(d);
            var v = new InstructorViewFactory().Create(e);
            isNotNull(v);
            isNotNull(e);
            areEqual(v.ID, e.ID);
            areEqual(v.InstrumentID, e.InstrumentID);
            areEqual(v.FirstName, e.FirstName);
            areEqual(v.LastName, e.LastName);
            areEqual(v.Email, e.Email);
            areEqual(v.PhoneNr, e.PhoneNr);
            areEqual(v.FullName, e.ToString());
        }
        [TestMethod] public void CreateEntityTest() 
        {
            var v = GetRandom.Value<InstructorView>() as InstructorView;
            var e = new InstructorViewFactory().Create(v);
            isNotNull(e);
            isNotNull(v);
            arePropertiesEqual(v, e);
            areNotEqual(e.ToString(), v.FullName);
        }
    }
}
