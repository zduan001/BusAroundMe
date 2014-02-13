using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _071_SearchInRotateArrayTest and is intended
    ///to contain all _071_SearchInRotateArrayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _071_SearchInRotateArrayTest
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
        ///A test for SearchRotateArray
        ///</summary>
        [TestMethod()]
        public void SearchRotateArrayTest()
        {
            _071_SearchInRotateArray target = new _071_SearchInRotateArray(); 
            int[] input = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            int value = 6; 
            int expected = 2; 
            int actual;
            actual = target.SearchRotateArray(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            value = 3;
            expected = -1;
            actual = target.SearchRotateArray(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 4, 4, 4, 4, 4, 4, 2 };
            value = 3;
            expected = -1;
            actual = target.SearchRotateArray(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 4, 4, 4, 4, 4, 4, 2 };
            value = 2;
            expected = 6;
            actual = target.SearchRotateArray(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 4, 2, 4, 4, 4, 4, 4 };
            value = 2;
            expected = 1;
            actual = target.SearchRotateArray(input, value);
            Assert.AreEqual(expected, actual);
        }


    }
}
