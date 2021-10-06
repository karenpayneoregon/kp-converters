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