﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_School_DB.Aids;
using Music_School_DB.Data.Party;
using System;
using System.Linq;
using System.Reflection;

namespace Music_School_DB.Tests.Aids
{
    [TestClass] public class GetAssemblyTests : TypeTests
    {
        private string? assemblyName;
        private Assembly? assembly;
        private string[] typenames = Array.Empty<string>();

        [TestInitialize] public void Init()
        {
            assemblyName = $"{nameof(Music_School_DB)}.{nameof(Music_School_DB.Aids)}";
            assembly = GetAssembly.ByName(assemblyName);
            typenames = new string[] { nameof(Chars), nameof(Enums), nameof(Lists), nameof(Strings), nameof(Safe), nameof(Types) };
        }
        [TestCleanup]
        public void Clean()
        {
            isNotNull(assembly);
            areEqual(assemblyName, assembly.GetName().Name);
        }
        [TestMethod] public void ByNameTest() { }
        [TestMethod] public void OfTypeTest()
        {
            assemblyName = $"{nameof(Music_School_DB)}.{nameof(Music_School_DB.Data)}";
            var obj = new CountryData();
            assembly = GetAssembly.OfType(obj);
        }
        [TestMethod] public void TypesTest()
        {
            var l = GetAssembly.Types(assembly);
            isTrue(typenames.Length <= (l?.Count ?? -2));
            foreach (var n in typenames)
                areEqual(l?.FirstOrDefault(x => x.Name == n)?.Name, n);
            isNull(l?.FirstOrDefault(x => x.Name == GetRandom.String()));
        }
        [TestMethod] public void TypeTest()
        {
            var n = randomTypeName;
            var obj = GetAssembly.Type(assembly, n);
            isNotNull(obj);
            areEqual(n, obj.Name);
        }
        private string randomTypeName => typenames[GetRandom.Int32(0, typenames.Length)];
    }
}
