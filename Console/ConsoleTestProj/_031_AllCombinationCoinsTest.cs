using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _031_AllCombinationCoinsTest and is intended
    ///to contain all _031_AllCombinationCoinsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _031_AllCombinationCoinsTest
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
        ///A test for FindAllCombinationCoins
        ///</summary>
        [TestMethod()]
        public void FindAllCombinationCoinsTest()
        {
            _031_AllCombinationCoins target = new _031_AllCombinationCoins(); // TODO: Initialize to an appropriate value
            int[] coins = new int[] {25,10,5,1};
            int total = 100;
            List<string> actual = target.FindAllCombinationCoins(coins, total);
            Assert.AreEqual(242, actual.Count);

            total = 25;
            actual = target.FindAllCombinationCoins(coins, total);
            Assert.AreEqual(13, actual.Count);
        }
    }
}
