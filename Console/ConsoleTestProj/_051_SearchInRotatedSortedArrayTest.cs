using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{


    /// <summary>
    ///This is a test class for _051_SearchInRotatedSortedArrayTest and is intended
    ///to contain all _051_SearchInRotatedSortedArrayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _051_SearchInRotatedSortedArrayTest
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
        ///A test for SearchinRotatedSortedArray
        ///</summary>
        [TestMethod()]
        public void SearchinRotatedSortedArrayTest()
        {
            _051_SearchInRotatedSortedArray target = new _051_SearchInRotatedSortedArray(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 4, 5, 6, 7, 8, 9, 1, 2, 3 };
            int value = 5;
            int expected = 1;
            int actual;
            actual = target.SearchinRotatedSortedArray(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 4, 5, 6, 7, 8, 9, 1, 2, 3 };
            value = 2;
            expected = 7;
            actual = target.SearchinRotatedSortedArray(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 4, 5, 6, 7, 8, 100, 1, 2, 3 };
            value = 9;
            expected = -1;
            actual = target.SearchinRotatedSortedArray(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 4, 5, 6, 7, 8, 100, 1, 2, 3 };
            value = 4;
            expected = 0;
            actual = target.SearchinRotatedSortedArray(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 4, 5, 6, 7, 8, 100, 1, 2, 3 };
            value = 3;
            expected = 8;
            actual = target.SearchinRotatedSortedArray(input, value);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SearchRotatedSortedArrayWithDup
        ///</summary>
        [TestMethod()]
        public void SearchRotatedSortedArrayWithDupTest()
        {
            _051_SearchInRotatedSortedArray target = new _051_SearchInRotatedSortedArray(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 4, 4, 4, 5, 6, 7, 8, 9, 1, 2, 3, 3 };
            int value = 5; 
            int expected = 3; 
            int actual;
            actual = target.SearchRotatedSortedArrayWithDup(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 4, 4, 4, 5, 6, 7, 8, 9, 1, 2, 3, 3 };
            value = 2;
            expected = 9;
            actual = target.SearchRotatedSortedArrayWithDup(input, value);
            Assert.AreEqual(expected, actual);


            input = new int[] { 4, 4, 4, 5, 6, 7, 8, 9, 1, 2, 3, 3 };
            value = 6;
            expected = 4;
            actual = target.SearchRotatedSortedArrayWithDup(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 4, 4, 4, 5, 6, 7, 8, 9, 1, 2, 3, 3 };
            value = 7;
            expected = 5;
            actual = target.SearchRotatedSortedArrayWithDup(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 4, 4, 4, 5, 6, 7, 8, 9, 1, 2, 3, 3 };
            value = 1;
            expected = 8;
            actual = target.SearchRotatedSortedArrayWithDup(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 4, 4, 4, 5, 6, 7, 8, 100, 1, 2, 3, 3 };
            value = 9;
            expected = -1;
            actual = target.SearchRotatedSortedArrayWithDup(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 4, 4, 4, 5, 6, 7, 8,8, 100, 1, 2, 3, 3 };
            value = 8;
            actual = target.SearchRotatedSortedArrayWithDup(input, value);
            Assert.IsTrue(6 == actual || 7 == actual);

            input = new int[] { 4, 4, 4, 5, 6, 7, 8, 8, 100, 1, 2, 3, 3 };
            value = 4;
            actual = target.SearchRotatedSortedArrayWithDup(input, value);
            Assert.IsTrue(0 == actual || 1 == actual || 2 == actual);

            input = new int[] { 4, 4, 4, 5, 6, 7, 8, 8, 100, 1, 2, 3, 3 };
            value = 3;
            actual = target.SearchRotatedSortedArrayWithDup(input, value);
            Assert.IsTrue(11 == actual || 12 == actual);
        }
    }
}
