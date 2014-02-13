using CareerCup150.Chapter19_Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _19_05_MasterMindTest and is intended
    ///to contain all _19_05_MasterMindTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _19_05_MasterMindTest
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
        ///A test for Response
        ///</summary>
        [TestMethod()]
        public void ResponseTest()
        {
            _19_05_MasterMind target = new _19_05_MasterMind(); // TODO: Initialize to an appropriate value
            string real = "RGGB";
            string guess = "YRGB";
            string expected = "Hits " + "2" + ", PseudoHits " + "1" + ".";
            string actual;
            actual = target.Response(real, guess);
            Assert.AreEqual(expected, actual);
        }
    }
}
