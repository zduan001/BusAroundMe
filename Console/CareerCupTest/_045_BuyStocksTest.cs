using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _045_BuyStocksTest and is intended
    ///to contain all _045_BuyStocksTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _045_BuyStocksTest
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
        ///A test for MaxProfit
        ///</summary>
        [TestMethod()]
        public void MaxProfitTest()
        {
            _045_BuyStocks target = new _045_BuyStocks(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 1, 2, 4, 2, 5, 7, 2, 4, 9, 0, 9 };
            int expected = 9; 
            int actual;
            actual = target.MaxProfit(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
