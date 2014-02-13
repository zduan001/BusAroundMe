using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _069_Search2DArrayTest and is intended
    ///to contain all _069_Search2DArrayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _069_Search2DArrayTest
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
        ///A test for Search
        ///</summary>
        [TestMethod()]
        public void SearchTest()
        {
            _069_Search2DArray target = new _069_Search2DArray(); // TODO: Initialize to an appropriate value
            int[,] input = new int[,] { { 1, 3, 5, 7 }, { 10, 11, 16, 20 }, { 23, 30, 34, 50 }, {51, 52, 53, 54 }};
            int value = 11; 
            int n = 4; 
            bool expected = true;
            bool actual;
            actual = target.Search(input, value, n);
            Assert.AreEqual(expected, actual);


            input = new int[,] { { 1, 3, 5, 7 }, { 10, 11, 16, 20 }, { 23, 30, 34, 50 }, { 51, 52, 53, 54 } };
            value = 21;
            n = 4;
            expected = false;
            actual = target.Search(input, value, n);
            Assert.AreEqual(expected, actual);

            input = new int[,] { { 1, 3, 5, 7 }, { 10, 11, 16, 20 }, { 23, 30, 34, 50 }, { 51, 52, 53, 54 } };
            value = 17;
            n = 4;
            expected = false;
            actual = target.Search(input, value, n);
            Assert.AreEqual(expected, actual);
        }
    }
}
