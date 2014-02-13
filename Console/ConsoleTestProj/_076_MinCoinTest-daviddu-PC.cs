using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _076_MinCoinTest and is intended
    ///to contain all _076_MinCoinTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _076_MinCoinTest
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
        ///A test for FindMinCoins
        ///</summary>
        [TestMethod()]
        public void FindMinCoinsTest()
        {
            _076_MinCoin target = new _076_MinCoin(); // TODO: Initialize to an appropriate value
            List<int> coins = new List<int> { 1, 5, 10, 25 };
            int value = 20;
            int  actual = target.FindMinCoins(coins, value);
            
        }

        /// <summary>
        ///A test for FindMinCoins
        ///</summary>
        [TestMethod()]
        public void FindMinCoinsTest1()
        {
            _076_MinCoin target = new _076_MinCoin(); // TODO: Initialize to an appropriate value
            List<int> coins = new List<int> { 1, 5, 10, 25 };
            int value = 20; 
            int expected = 2; 
            int actual;
            actual = target.FindMinCoins(coins, value);
            Assert.AreEqual(expected, actual);
        }
    }
}
