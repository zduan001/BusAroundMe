using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _070_ValidParenthesesTest and is intended
    ///to contain all _070_ValidParenthesesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _070_ValidParenthesesTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for ValidParentheses
        ///</summary>
        [TestMethod()]
        public void ValidParenthesesTest()
        {
            _070_ValidParentheses target = new _070_ValidParentheses(); // TODO: Initialize to an appropriate value
            string s = "[({(())}[()])]";
            bool expected = true;
            bool actual;
            actual = target.ValidParentheses(s);
            Assert.AreEqual(expected, actual);

            s = "[({((())}[()])]";
            expected = false;
            actual = target.ValidParentheses(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
