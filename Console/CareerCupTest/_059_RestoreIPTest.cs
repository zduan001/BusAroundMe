using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _059_RestoreIPTest and is intended
    ///to contain all _059_RestoreIPTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _059_RestoreIPTest
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
        ///A test for RestoreIp
        ///</summary>
        [TestMethod()]
        public void RestoreIpTest()
        {
            _059_RestoreIP target = new _059_RestoreIP(); // TODO: Initialize to an appropriate value
            string s = "125324";
            List<string> actual;
            actual = target.RestoreIp(s);

            Assert.IsTrue(actual.Contains("1,2,53,24"));
            Assert.IsTrue(actual.Contains("1,25,3,24"));
            Assert.IsTrue(actual.Contains("1,25,32,4"));
            Assert.IsTrue(actual.Contains("12,5,3,24"));
            Assert.IsTrue(actual.Contains("12,5,32,4"));
            Assert.IsTrue(actual.Contains("1,253,2,4"));
            Assert.IsTrue(actual.Contains("12,53,2,4"));
            Assert.IsTrue(actual.Contains("125,3,2,4"));

        }
    }
}
