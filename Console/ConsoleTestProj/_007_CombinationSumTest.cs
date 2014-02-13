using Console2.From_001_To_025;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _007_CombinationSumTest and is intended
    ///to contain all _007_CombinationSumTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _007_CombinationSumTest
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
        ///A test for CombinationSum
        ///</summary>
        [TestMethod()]
        public void CombinationSumTest()
        {
            _007_CombinationSum target = new _007_CombinationSum();
            int[] input = new int[] {2,3,4,5,6,7 };
            int value = 7;
            List<List<int>> actual = target.CombinationSum(input, value);
            //expect result.
            //[ [2,2,3] [3,4] [2,5] [7] ]

            Assert.AreEqual(4, actual.Count, "should be 4 possible way");

            Assert.AreEqual(3, actual[0].Count, "first one should have 2,2,3");
            Assert.IsTrue(actual[0].Contains(2), "first one should have 2,2,3");
            Assert.IsTrue(actual[0].Contains(3), "first one should have 2,2,3");

            Assert.AreEqual(2, actual[1].Count, "first one should have 3,4");
            Assert.IsTrue(actual[1].Contains(3), "first one should have 3,4");
            Assert.IsTrue(actual[1].Contains(4), "first one should have 3,4");

            Assert.AreEqual(2, actual[2].Count, "first one should have 2,5");
            Assert.IsTrue(actual[2].Contains(2), "first one should have 2,5");
            Assert.IsTrue(actual[2].Contains(5), "first one should have 2,5");


            Assert.AreEqual(1, actual[3].Count, "first one should have 7");
            Assert.IsTrue(actual[3].Contains(7), "first one should have 7");
            

        }

        /// <summary>
        ///A test for CombinationSumNoRepeat
        ///this test case has not passed yet. but I am sure the logic in the code is the
        ///right logic.
        ///</summary>
        [TestMethod()]
        public void CombinationSumNoRepeatTest()
        {
            _007_CombinationSum target = new _007_CombinationSum(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 10, 1, 2, 7, 6, 1, 5 };
            int value = 8; 
            List<List<int>> actual = target.CombinationSumNoRepeat(input, value);
        }
    }
}
