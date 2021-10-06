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
    public partial class IntTests : TestBase
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Int)]
        public void PositiveToNegativeTest()
        {
            int value = 10;

            Assert.AreEqual(value.Invert(),-10);

            /*
             * Flip to negative
             */
            value *= (-1);
            Assert.AreEqual(value.Invert(), 10);
        }

        [TestMethod]
        [TestTraits(Trait.Int)]
        public void IsPositive()
        {
            int value = 10;
            Assert.IsTrue(value.IsPositive());
        }

        [TestMethod]
        [TestTraits(Trait.Int)]
        public void IsNegative()
        {
            int value = -10;
            Assert.IsTrue(value.IsNegative());
        }

        [TestMethod]
        [TestTraits(Trait.Int)]
        public void IntToDecimalTest()
        {
            int value = 10;
            Assert.AreEqual(value.IntToDecimal(), (decimal).1);
        }

        [TestMethod]
        [TestTraits(Trait.Int)]
        public void IntToYesNoTest()
        {
            int value = -1;
            Assert.ThrowsException<InvalidOperationException>(() => value.ToYesNo());

            value = 2;
            Assert.ThrowsException<InvalidOperationException>(() => value.ToYesNo());

            value = 0;
            Assert.AreEqual(value.ToYesNo(),"No");

            value = 1;
            Assert.AreEqual(value.ToYesNo(), "Yes");

        }

        /// <summary>
        /// These test pass but there is an issue, what is it?
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Int)]
        public void IntToYesNoFormattedTest()
        {

            int value = 1;
            Assert.AreEqual(value.ToYesNoFormat(), "Yes");

            value = 0;
            Assert.AreEqual(value.ToYesNoFormat(), "No");

            
            value = 10;
            Assert.AreEqual(value.ToYesNoFormat(), "Yes");

        }

        [TestMethod]
        [TestTraits(Trait.Int)]
        public void PercentDoneTest()
        {
            Dictionary<int, string> dictionary = new()
            {
                { 0, "" },
                { 2, "1%" },
                { 5, "4%" },
                { 15, "12%" },
                { 62, "50%" },
                { 95, "76%" },
                { 110, "88%" },
                { 125, "100%" }
            };

            dictionary.ToList().ForEach(kvp => 
                Assert.AreEqual(kvp.Key.PercentDone(125), kvp.Value));
            
        }

        [TestMethod]
        [TestTraits(Trait.Int)]
        public void PercentDoneExceptionsTest()
        {

            int value = -1;

            Assert.ThrowsException<ArgumentException>(() => value.PercentDone(125));
            value = 145;
            Assert.ThrowsException<ArgumentException>(() => value.PercentDone(125));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [TestTraits(Trait.Int)]
        public void PercentDoneExceptionsDoneWrongTest()
        {

            int value = -1;

            var result = value.PercentDone(125);

            value = 145;
            result = value.PercentDone(125);
            
        }


    }

}

