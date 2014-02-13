using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{


    /// <summary>
    ///This is a test class for _024_LongestIncreaseSubSeqTest and is intended
    ///to contain all _024_LongestIncreaseSubSeqTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _024_LongestIncreaseSubSeqTest
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
        ///A test for LongestIncreasePath
        ///</summary>
        [TestMethod()]
        public void LongestIncreasePathTest()
        {
            _024_LongestIncreaseSubSeq target = new _024_LongestIncreaseSubSeq(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 2, 6, 4, 5, 1, 3, 7 };
            int expected = 4; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.LongestIncreasePath(input);
            Assert.AreEqual(expected, actual);


            input = new int[] { 10, 2, 6, 4, 5, 1, 3 };
            expected = 3;
            actual = target.LongestIncreasePath(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
