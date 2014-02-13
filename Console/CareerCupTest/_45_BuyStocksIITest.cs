using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _45_BuyStocksIITest and is intended
    ///to contain all _45_BuyStocksIITest Unit Tests
    ///</summary>
    [TestClass()]
    public class _45_BuyStocksIITest
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
        ///A test for MaxProfitII
        ///</summary>
        [TestMethod()]
        public void MaxProfitIITest()
        {
            _45_BuyStocksII target = new _45_BuyStocksII(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 1, 2, 4, 2, 5, 7, 2, 4, 9, 0, 9 };
            int expected = 24;
            int actual;
            actual = target.MaxProfitII(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
