using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _019_BuySellStocksTest and is intended
    ///to contain all _019_BuySellStocksTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _019_BuySellStocksTest
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
        ///A test for MaxProfileOneTransaction
        ///</summary>
        [TestMethod()]
        public void MaxProfileOneTransactionTest()
        {
            _019_BuySellStocks target = new _019_BuySellStocks(); 
            int[] prices =new int[] {1,2,4,2,5,7,2,4,9,0,9};
            int expected = 9; 
            int actual;
            actual = target.MaxProfileOneTransaction(prices);
            Assert.AreEqual(expected, actual);

            prices =new int[]{1,2,4,2,5,7,2,4,9,0};
            expected = 8; 
            actual = target.MaxProfileOneTransaction(prices);
            Assert.AreEqual(expected, actual);

            prices = new int[] { };
            expected = 0;
            actual = target.MaxProfileOneTransaction(prices);
            Assert.AreEqual(expected, actual);

            prices = new int[] {1};
            expected = 0;
            actual = target.MaxProfileOneTransaction(prices);
            Assert.AreEqual(expected, actual);

            prices = new int[] { 3,3 };
            expected = 0;
            actual = target.MaxProfileOneTransaction(prices);
            Assert.AreEqual(expected, actual);

            prices = new int[] { 3, 3,3,3,3,3,3 };
            expected = 0;
            actual = target.MaxProfileOneTransaction(prices);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for MaxProfitOneTransactionN2
        ///</summary>
        [TestMethod()]
        public void MaxProfitOneTransactionN2Test()
        {
            _019_BuySellStocks target = new _019_BuySellStocks(); 
            int[] prices = new int[] { 1, 2, 4, 2, 5, 7, 2, 4, 9, 0, 9 }; // TODO: Initialize to an appropriate value
            int expected = 9; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.MaxProfitOneTransactionN2(prices);
            Assert.AreEqual(expected, actual);

            prices = new int[] { 1, 2, 4, 2, 5, 7, 2, 4, 9, 0 }; 
            expected = 8; 
            actual = target.MaxProfitOneTransactionN2(prices);
            Assert.AreEqual(expected, actual);

            prices = new int[] { };
            expected = 0;
            actual = target.MaxProfitOneTransactionN2(prices);
            Assert.AreEqual(expected, actual);

            prices = new int[] { 1 };
            expected = 0;
            actual = target.MaxProfitOneTransactionN2(prices);
            Assert.AreEqual(expected, actual);

            prices = new int[] { 3, 3 };
            expected = 0;
            actual = target.MaxProfitOneTransactionN2(prices);
            Assert.AreEqual(expected, actual);

            prices = new int[] { 3, 3, 3, 3, 3, 3, 3 };
            expected = 0;
            actual = target.MaxProfitOneTransactionN2(prices);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for MaxProfitUnlimitedTransaction
        ///</summary>
        [TestMethod()]
        public void MaxProfitUnlimitedTransactionTest()
        {
            _019_BuySellStocks target = new _019_BuySellStocks(); // TODO: Initialize to an appropriate value
            int[] prices = new int[] { 1, 2, 4, 2, 5, 7, 2, 4, 9, 0, 9 };
            int expected = 24;
            int actual;
            actual = target.MaxProfitUnlimitedTransaction(prices);
            Assert.AreEqual(expected, actual);


            prices = new int[] { 1, 2, 4, 2, 5, 7, 2, 4, 9, 0 };
            expected = 15;
            actual = target.MaxProfitUnlimitedTransaction(prices);
            Assert.AreEqual(expected, actual);

            prices = new int[] {};
            expected = 0;
            actual = target.MaxProfitUnlimitedTransaction(prices);
            Assert.AreEqual(expected, actual);

            prices = new int[] { 1 };
            expected = 0;
            actual = target.MaxProfitUnlimitedTransaction(prices);
            Assert.AreEqual(expected, actual);

            prices = new int[] { 3, 3 };
            expected = 0;
            actual = target.MaxProfitUnlimitedTransaction(prices);
            Assert.AreEqual(expected, actual);

            prices = new int[] { 3, 3, 3, 3, 3, 3, 3 };
            expected = 0;
            actual = target.MaxProfitUnlimitedTransaction(prices);
            Assert.AreEqual(expected, actual);
        }
    }
}
