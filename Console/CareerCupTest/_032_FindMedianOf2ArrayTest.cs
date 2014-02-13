using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _032_FindMedianOf2ArrayTest and is intended
    ///to contain all _032_FindMedianOf2ArrayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _032_FindMedianOf2ArrayTest
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
        ///A test for FindMedian
        ///</summary>
        [TestMethod()]
        public void FindMedianTest()
        {
            _032_FindMedianOf2Array target = new _032_FindMedianOf2Array(); // TODO: Initialize to an appropriate value
            int[] a1 = new int[] { 1, 2, 3, 4, 5 };
            int[] a2 = new int[] { 6, 7, 8, 9 };
            int expected = 5;
            int actual;
            actual = target.FindMedian(a1, a2);
            Assert.AreEqual(expected, actual);

            a1 = new int[] { 1, 7, 3, 9, 5 };
            a2 = new int[] { 6, 2, 8, 4 };
            expected = 5;
            actual = target.FindMedian(a1, a2);
            Assert.AreEqual(expected, actual);
        }
    }
}
