﻿using System.Collections.Generic;
using NUnit.Framework;
using Shouldly;

namespace Bolt.Common.Extensions.UnitTests
{
    [TestFixture]
    public class DictionaryExtensionsTests
    {
        [Test]
        public void GetValueOrDefaultTest()
        {
            var source = new Dictionary<string, string> {{"name", "ruhul"}};

            source.GetValueOrDefault("name").ShouldBe("ruhul");
            source.GetValueOrDefault("postcode").ShouldBe(null);
            source.GetValueOrDefault("postcode", "3000").ShouldBe("3000");
        }
    }
}