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
    public partial class GenericConverterTests :TestBase
    {
        /// <summary>
        /// Demonstrates a generic extension method to blindly convert one type to another type.
        /// In this case an int array to a string array,
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.GenericConverter)]
        public void GenericTest()
        {
            List<object> sourceList = new() { 1, null, 3 };
            IList resultList = sourceList.ConvertToList(typeof(string));

            Assert.IsTrue(resultList.GetType() == typeof(List<string>));

            /*
             * Not a test, instead a working example
             */
            if (resultList is List<string> list)
            {
                for (int index = 0; index < list.Count; index++)
                {
                    Debug.WriteLine($"{index,-4}{(string.IsNullOrWhiteSpace(list[index]) ? "(null)" : list[index]),-4}");
                }
            }
        }

        [TestMethod]
        [TestTraits(Trait.GenericConverter)]
        public void GenericChunk()
        {

            List<int> intItems = Enumerable.Range(1, 15).ToList();
            IEnumerable<IEnumerable<int>> intResults = intItems.Chunk(5);

            string[] stringItems = { "Mary", "Joe", "Ken", "Annie", "Bob", "Karen", "Mark", "Bick", "Lisa", "Bill" };
            IEnumerable<IEnumerable<string>> stringResults = stringItems.Chunk(5);
            Console.WriteLine();
        }

    }

}