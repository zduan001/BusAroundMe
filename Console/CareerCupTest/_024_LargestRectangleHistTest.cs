using Console2.From_001_To_025;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _024_LargestRectangleHistTest and is intended
    ///to contain all _024_LargestRectangleHistTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _024_LargestRectangleHistTest
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
        ///A test for FindLargestHistogram
        ///</summary>
        [TestMethod()]
        public void FindLargestHistogramTest()
        {
            _024_LargestRectangleHist target = new _024_LargestRectangleHist(); // TODO: Initialize to an appropriate value
            int[] bars = new int[] { 2, 1, 5, 6, 2, 3 };
            int expected = 10; 
            int actual = target.FindLargestHistogram(bars);
            Assert.AreEqual(expected, actual);
        }
    }
}
