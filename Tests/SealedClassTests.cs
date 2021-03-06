using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Music_School_DB.Tests
{
    public abstract class SealedClassTests<TClass, TBaseClass> : BaseTests<TClass, TBaseClass> where TClass : class, new() where TBaseClass : class
    {
        protected override TClass createObj() => new TClass();
        [TestMethod] public void IsSealedTest() => isTrue(obj?.GetType()?.IsSealed ?? false);
    }
}
