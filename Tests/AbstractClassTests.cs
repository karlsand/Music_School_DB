﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Music_School_DB.Tests
{
    public abstract class AbstractClassTests<TClass, TBaseClass> : BaseTests<TClass, TBaseClass> where TClass : class where TBaseClass : class
    {
        [TestMethod] public void IsAbstractTest() => isTrue(obj?.GetType()?.BaseType?.IsAbstract ?? false);
    }
}
