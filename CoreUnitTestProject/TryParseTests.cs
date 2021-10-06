using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ConverterLibrary.LanguageExtensions;
using CoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreUnitTestProject
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class TryParseTests : TestBase
    {
        /// <summary>
        /// Testing TryParse extension method on string to int
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.TryParse)]
        public void IntParseTest()
        {
            string value = "12";
            Assert.AreEqual(12, value.TryParseInt32());

            value = "12A";
            Assert.AreNotEqual(12, value.TryParseInt32());
            Assert.AreEqual(0, value.TryParseInt32());
        }

        /// <summary>
        /// Testing TryParse extension method on string to DateTime
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.TryParse)]
        public void DateTimeParseTest()
        {
            DateTime expected = new DateTime(2021, 2, 23, 8, 1, 0);

            var converted = "2/23/2021 8:01:00 AM".TryParseDateTime();

            Assert.AreEqual(converted, expected);
            Assert.IsTrue("22/23/2021 8:01:00 AM".TryParseDateTime().Year == 1);

        }



    }

}