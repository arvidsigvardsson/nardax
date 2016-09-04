using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nardax.Tests
{
    [TestClass]
    public class AsseblyExtensionsTests
    {
        [TestMethod]
        public void GetAppSettingsValue_ValidKey_ReturnsValue()
        {
            yyyyyyyyyyyyyy
                yyyyyyyyyyyyy
                yyyyyyyyyyyyy
            var validKey = "ValidKey";
            var expectedAppSettingVlaue = "SomeValue";

            var assembly = Assembly.GetExecutingAssembly();
            var actualAppSettingValue = assembly.GetAppSettingsValue(validKey);

            Assert.AreEqual(expectedAppSettingVlaue, actualAppSettingValue);
        }
        fffffffffffffffffffffffffembly();
            assembly.GetAppSettingsValue(invalidKey);

            Assert.Fail();
        }
    }
}