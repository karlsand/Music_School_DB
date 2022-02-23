using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Music_School_DB.Tests
{
    public abstract class AssertTests
    {
        protected static void inconclusive() => Assert.Inconclusive();
        protected static void isNotNull([NotNull] object? o = null) => Assert.IsNotNull(o);
        protected static void areEqual(object? expected, object? acutal) => Assert.AreEqual(expected, acutal);
    }
}
