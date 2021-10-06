using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable once CheckNamespace - do not change
namespace CoreUnitTestProject
{
    public partial class IntTests
    {
        [TestInitialize]
        public void Initialization()
        {

        }
        [ClassInitialize()]
        public static void ClassInitialize(TestContext testContext)
        {
            TestResults = new List<TestContext>();
        }
    }
}
