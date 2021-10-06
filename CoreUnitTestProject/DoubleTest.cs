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
    public class DoubleTest
    {
        /// <summary>
        /// Test obtaining int and decimal part of a double
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Double)]
        public void GetPartsTest()
        {
            double value = 11.33;

            var (major, fraction) = value.GetParts();
            Assert.AreEqual(major, 11);

            Assert.AreEqual(fraction, (decimal).33);


            /*
             * Flip to negative
             */
            value *= (-1);
            (major, fraction) = value.GetParts();

            Assert.AreEqual(major, -11);
            Assert.AreEqual(fraction, (decimal)-.33);

        }

        /// <summary>
        /// Test calculating percentage of a number
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Double)]
        public void PercentDoneTest()
        {

            double percentDone = 50;
            double total = 125;
            Assert.AreEqual(62.5, total.PercentOf(percentDone));
            Console.WriteLine(total.PercentOf(percentDone));
            percentDone = 10;
            Console.WriteLine(total.PercentOf(percentDone));

        }

    }

}