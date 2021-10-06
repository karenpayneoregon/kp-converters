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
    /// Provides two examples for testing for an exception expected from an whatever
    /// is being tested.
    /// </summary>
    [TestClass]
    public partial class DealingWithExceptionsTesting : TestBase
    {

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MethodAttributeExample()
        {
            StringAppend("Karen", "Payne");
        }
        [TestMethod]
        public void InlineAttributeExample()
        {
            Assert.ThrowsException<Exception>(() => StringAppend("Karen", "Payne"));
        }

    }

}