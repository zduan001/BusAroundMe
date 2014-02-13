using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _033_RegularExpressionMatchingTest and is intended
    ///to contain all _033_RegularExpressionMatchingTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _034_RegularExpressionMatchingTest
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
        ///A test for RegularExpressionMatching
        ///</summary>
        [TestMethod()]
        public void RegularExpressionMatchingTest()
        {
            string s = "aab";
            string p = "c*a*b";
            bool expected = true; 
            bool actual;
            actual = _033_RegularExpressionMatching.RegularExpressionMatching(s, p);
            Assert.AreEqual(expected, actual);

            s = "bbc";
            p = "b*bc";
            actual = _033_RegularExpressionMatching.RegularExpressionMatching(s, p);
            Assert.AreEqual(expected, actual);
        }
    }
}
