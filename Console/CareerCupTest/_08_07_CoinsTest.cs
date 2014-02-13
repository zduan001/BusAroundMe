using CareerCup150.Chapter8_Recursion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _08_07_CoinsTest and is intended
    ///to contain all _08_07_CoinsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _08_07_CoinsTest
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
        ///A test for CoinsCombination
        ///</summary>
        [TestMethod()]
        public void CoinsCombinationTest()
        {
            _08_07_Coins target = new _08_07_Coins(); 
            int[] coinsValue =new  int[] {1,5,10,25};
            int value = 6; 
            List<List<int>> actual = target.CoinsCombination(coinsValue, value);
            Assert.AreEqual(2, actual.Count);
        }
    }
}
