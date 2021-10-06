using System;

namespace CoreUnitTestProject.Base
{
    /// <summary>
    /// For demonstrating dealing with expected exceptions in test methods
    /// </summary>
    public class StringIssues
    {
        /// <summary>
        /// Dummy method to invoke an <see cref="Exception"/>
        /// </summary>
        /// <param name="firstName">first name</param>
        /// <param name="lastName">last name</param>
        /// <returns></returns>
        public static string StringAppend(string firstName, string lastName)
        {
            throw new Exception("Test Exception");
        }
    }
}