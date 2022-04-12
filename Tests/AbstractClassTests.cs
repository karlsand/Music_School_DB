﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Music_School_DB.Tests
{
    public abstract class AbstractClassTests : BaseTests
    {
        [TestMethod] public void IsAbstractTest() => isTrue(obj?.GetType()?.BaseType?.IsAbstract ?? false);
    }
}
