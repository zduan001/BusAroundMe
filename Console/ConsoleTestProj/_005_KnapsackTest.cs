using console.DP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _005_KnapsackTest and is intended
    ///to contain all _005_KnapsackTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _005_KnapsackTest
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
        ///A test for KnapsackNoRepetition
        ///</summary>
        [TestMethod()]
        public void KnapsackNoRepetitionTest()
        {
            _005_Knapsack target = new _005_Knapsack(); // TODO: Initialize to an appropriate value
            int[] weight = new int[] { 6, 3, 4, 2 };
            int[] value = new int[] { 30, 14, 16, 9 };
            int capacity = 10; 
            int expected = 46; 
            int actual;
            actual = target.KnapsackNoRepetition(weight, value, capacity);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for KnapsackNoRepititionOneDArray
        ///</summary>
        [TestMethod()]
        public void KnapsackNoRepititionOneDArrayTest()
        {
            _005_Knapsack target = new _005_Knapsack(); // TODO: Initialize to an appropriate value
            int[] weight = new int[] { 6, 3, 4, 2 };
            int[] value = new int[] { 30, 14, 16, 9 };
            int capacity = 10;
            int expected = 46; 
            int actual;
            actual = target.KnapsackNoRepititionOneDArray(weight, value, capacity);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for KnapsackNoRepititionOneOneDArray
        ///</summary>
        [TestMethod()]
        public void KnapsackNoRepititionOneOneDArrayTest()
        {
            _005_Knapsack target = new _005_Knapsack(); // TODO: Initialize to an appropriate value
            int[] weight = new int[] { 6, 3, 4, 2 };
            int[] value = new int[] { 30, 14, 16, 9 };
            int capacity = 10;
            int expected = 46; 
            int actual;
            actual = target.KnapsackNoRepititionOneOneDArray(weight, value, capacity);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for KnapsackNoRepititionOneOneDArrayIncreasedLowBound
        ///</summary>
        [TestMethod()]
        public void KnapsackNoRepititionOneOneDArrayIncreasedLowBoundTest()
        {
            _005_Knapsack target = new _005_Knapsack(); // TODO: Initialize to an appropriate value
            int[] weight = new int[] { 6, 3, 4, 2 };
            int[] value = new int[] { 30, 14, 16, 9 };
            int capacity = 10;
            int expected = 46; 
            int actual;
            actual = target.KnapsackNoRepititionOneOneDArrayIncreasedLowBound(weight, value, capacity);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for KnapsackWithRepitition
        ///</summary>
        [TestMethod()]
        public void KnapsackWithRepititionTest()
        {
            _005_Knapsack target = new _005_Knapsack(); // TODO: Initialize to an appropriate value
            int[] weight = new int[] { 6, 3, 4, 2 };
            int[] value = new int[] { 30, 14, 16, 9 };
            int capacity = 10;
            int expected = 48; 
            int actual;
            actual = target.KnapsackWithRepitition(weight, value, capacity);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for KnapsackWithRepititionReverseLoop
        ///</summary>
        [TestMethod()]
        public void KnapsackWithRepititionReverseLoopTest()
        {
            _005_Knapsack target = new _005_Knapsack(); // TODO: Initialize to an appropriate value
            int[] weight = new int[] { 6, 3, 4, 2 };
            int[] value = new int[] { 30, 14, 16, 9 };
            int capacity = 10;
            int expected = 48;
            int actual;
            actual = target.KnapsackWithRepititionReverseLoop(weight, value, capacity);
            Assert.AreEqual(expected, actual);
        }
    }
}
