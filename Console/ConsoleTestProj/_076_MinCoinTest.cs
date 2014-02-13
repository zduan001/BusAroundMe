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
            List<int> coins = new List<int> { 1, 5, 10,20, 25 };
            int value = 40;
            List<int> actual = target.FindMinCoins(coins, value);
            Assert.AreEqual(2, actual.Count);
            Assert.IsTrue(actual.Contains(20));

            int temp = 0;
            foreach (int i in actual)
            {
                temp += i;
            }
            Assert.AreEqual(value, temp);




            coins = new List<int> { 1, 2, 3, 5, 8, 12, 15, 21, 37, 56 };
            value = 189;
            actual = target.FindMinCoins(coins, value);
            Assert.AreEqual(4, actual.Count);
            Assert.IsTrue(actual.Contains(56));
            Assert.IsTrue(actual.Contains(21));

            temp = 0;
            foreach (int i in actual)
            {
                temp += i;
            }
            Assert.AreEqual(value, temp);
        }
    }
}
