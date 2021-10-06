using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CoreUnitTestProject.Base
{
    public class TestBase : StringIssues
    {
        protected TestContext TestContextInstance;
        public TestContext TestContext
        {
            get => TestContextInstance;
            set
            {
                TestContextInstance = value;
                TestResults.Add(TestContext);
            }
        }

        public static IList<TestContext> TestResults;
    }
}
