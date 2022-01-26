using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreUnitTestProject
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class StructTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void StructNullable()
        {
            var testArray = new TestStruct?[]
            {
                new TestStruct { Name = "Karen"},
                null,
                new TestStruct{Name="John"}
            };

            var result = ConvertWithout(testArray);

            foreach (var person in result)
            {
                Console.WriteLine(person.Name);
            }
        }

        public static T[] ConvertWithout<T>(T?[] array) where T : struct =>
            array.OfType<T>().ToArray();
    }

}