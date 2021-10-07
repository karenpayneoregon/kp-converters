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
    public partial class SequenceTest : TestBase
    {

        /// <summary>
        /// Validate SequenceFindMissing extension
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Sequences)]
        public void SequenceFindMissingIntegersTest()
        {
            int[] array = { 1, 2, 3, 5, 6, 8, 9, 10 };
            List<int> expected = new () {4,7 };

            CollectionAssert.AreEqual(
                expected, 
                array.SequenceFindMissing().Cast<int>().ToList());

        }


        /// <summary>
        /// Same as above with slightly larger array
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Sequences)]
        public void SequenceFindMissingIntegersTest1()
        {

            int[] array =
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14, 15, 16, 17, 18, 19, 20, 21, 23, 24, 25,
                26, 27, 28, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 46, 47, 48,
                49, 50
            };

            List<int> expected = new() { 13, 22, 29, 45 };

            CollectionAssert.AreEqual(
                expected,
                array.SequenceFindMissing().Cast<int>().ToList());

        }
        /// <summary>
        /// Validate SequenceFindMissing extension
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Sequences)]
        public void SequenceHasMissingElementsTest()
        {
            int[] array = { 1, 2, 3, 5, 6, 8, 9, 10 };

            Assert.IsTrue(array.IsSequenceBroken());

        }


    }

}