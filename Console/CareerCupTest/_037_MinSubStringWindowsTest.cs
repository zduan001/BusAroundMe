using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _037_MinSubStringWindowsTest and is intended
    ///to contain all _037_MinSubStringWindowsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _037_MinSubStringWindowsTest
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
        ///A test for FindMinSubStrWindows
        ///</summary>
        [TestMethod()]
        public void FindMinSubStrWindowsTest()
        {
            _037_MinSubStringWindows target = new _037_MinSubStringWindows(); // TODO: Initialize to an appropriate value
            string s = "ADOBECODEBANC";
            string p = "BAC";
            string expected = "BANC";
            string actual;
            actual = target.FindMinSubStrWindows(s, p);
            Assert.AreEqual(expected, actual);
        }
    }
}
