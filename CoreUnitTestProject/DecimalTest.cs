using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using ConverterLibrary.LanguageExtensions;
using CoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreUnitTestProject
{
    [TestClass]
    public partial class DecimalTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.Decimals)]
        public void CountDecimalPlacesTest()
        {
            // arrange
            var dictionary = new Dictionary<decimal, int>
            {   { 1, 0 },              { 1.1m, 1 },       { 1.12m, 2 },       { 1.123m, 3 }, { 1.1234m, 4 }, { 1.12345m, 5 },
                { 1.123456m, 6 },      { 1.1234567m, 7 }, { 1.12345678m, 8 }, { 1.123456789m, 9 },
                { 1.1234567891m, 10 }, { 1.123456789123456789m, 18 }
            };

            // act
            foreach (var kvp in dictionary)
            {
                // assert
                Assert.AreEqual(kvp.Key.CountDecimalPlaces(), kvp.Value);
            }
            
        }

        

        /// <summary>
        /// Flip positive to negative or negative to positive
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Decimals)]
        public void PositiveToNegativeTest()
        {
            decimal value = 11.33m;
            Assert.AreEqual(value.Invert(), (decimal)-11.33);

            value = -11.33m;
            Assert.AreEqual(value.Invert(), (decimal)11.33);


        }

 
    }
}
