using System;
using System.Collections;
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
    public partial class IntArrayTest : TestBase
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.IntArray)]
        public void AllIntTest()
        {
            var values = Enumerable.Range(1, 10)
                .Select(number => number.ToString())
                .ToArray();

            Assert.IsTrue(values.AllInt());

            values[3] = "A";
            Assert.IsFalse(values.AllInt());

        }

        [TestMethod]
        [TestTraits(Trait.IntArray)]
        public void IntArrayAverage()
        {
            string[] values = { "10", "20", "10", "30" };

            Assert.AreEqual(values.ToIntegerArray().Average(), 17.5);
        }


        [TestMethod]
        [TestTraits(Trait.IntArray)]
        public void ToIntegerArrayTest()
        {
            /*
             * Create a string array of odd values and assert against mocked int array
             */

            CollectionAssert.AreEqual(
                Enumerable.Range(2, 15).Where(number => number % 2 == 1)
                    .Select(current => current.ToString()).ToArray().ToIntegerArray(), 
                new[] {3,5,7,9,11,13,15});
        }

        /// <summary>
        /// Test obtaining values in a string array which cannot represent an int
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.IntArray)]
        public void GetNonIntegerIndexesTest()
        {
            string[] values = { "100","100B", "200", "200B", "1", "", "A", ".4", "2.3" };
            int[] expected = { 1, 3, 5, 6, 7, 8 };
            var results = values.GetNonIntegerIndexes();

            CollectionAssert.AreEqual(expected,results);

        }

        /// <summary>
        /// Test Converting all values in array to int array where non int values will be set to the default value.
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.IntArray)]
        public void ToIntegerPreserveArrayTest()
        {
            string[] values = { "100", "100B", "200", "200B", "1", "", "A", ".4", "2.3" };

            int[] expected = { 100, 0, 200, 0, 1, 0, 0, 0, 0 };
            var results = values.ToIntegerPreserveArray();

            CollectionAssert.AreEqual(expected, results);

        }






    }

}