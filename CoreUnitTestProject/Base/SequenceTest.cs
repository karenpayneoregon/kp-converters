using System.Collections.Generic;
using CoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable once CheckNamespace
namespace CoreUnitTestProject
{
    public partial class SequenceTest
    {
        [TestInitialize]
        public void Initialization()
        {

        }

        /// <summary>
        /// Perform any initialize for the class
        /// </summary>
        /// <param name="testContext"></param>
        [ClassInitialize()]
        public static void ClassInitialize(TestContext testContext)
        {
            TestResults = new List<TestContext>();
        }
    }
}
