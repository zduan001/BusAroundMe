using Console2.From_076_To_100;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _087_ValidParenthesesTest and is intended
    ///to contain all _087_ValidParenthesesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _087_ValidParenthesesTest
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
        ///A test for IsValidParentheses
        ///</summary>
        [TestMethod()]
        public void IsValidParenthesesTest()
        {
            _087_ValidParentheses target = new _087_ValidParentheses(); // TODO: Initialize to an appropriate value
            string str = "[({(())}[()])]";
            bool expected = true;
            bool actual;
            actual = target.IsValidParentheses(str);
            Assert.AreEqual(expected, actual);


            str = "[({((}))}[()])]";
            expected = false;
            actual = target.IsValidParentheses(str);
            Assert.AreEqual(expected, actual);
        }
    }
}
