using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _056_RegularExpressionMatchTest and is intended
    ///to contain all _056_RegularExpressionMatchTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _056_RegularExpressionMatchTest
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
        ///A test for MatchRegualrExpression
        ///</summary>
        [TestMethod()]
        public void MatchRegualrExpressionTest()
        {
            _056_RegularExpressionMatch target = new _056_RegularExpressionMatch(); // TODO: Initialize to an appropriate value
            string s = "aab";
            string p = "c*a*b";
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MatchRegualrExpression(s, p);
            Assert.AreEqual(expected, actual);
        }
    }
}
