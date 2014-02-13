using Console2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{


    /// <summary>
    ///This is a test class for _002_Find3Sum_Round2Test and is intended
    ///to contain all _002_Find3Sum_Round2Test Unit Tests
    ///</summary>
    [TestClass()]
    public class _002_Find3Sum_Round2Test
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
        ///A test for Find3Sum
        ///</summary>
        [TestMethod()]
        public void Find3SumTest()
        {
            _002_Find3Sum_Round2 target = new _002_Find3Sum_Round2();

            int[] input = { 1, -1, 0, 2, 3, -3, -2, -1, 5, 3 };
            List<List<int>> actual = target.Find3Sum(input);
            Assert.AreEqual(7, actual.Count, "expect {1,-1,0}");

            input = new int[] { 1, -1 };
            actual = target.Find3Sum(input);
            Assert.AreEqual(0, actual.Count, "expect {1,-1,0}");

            input = new int[] { 1, -1, 5, 7, 3, 9, 10 };
            actual = target.Find3Sum(input);
            Assert.AreEqual(0, actual.Count, "expect {1,-1,0}");
        }

        /// <summary>
        ///A test for FindClosest3Sum
        ///</summary>
        [TestMethod()]
        public void FindClosest3SumTest()
        {
            _002_Find3Sum_Round2 target = new _002_Find3Sum_Round2();
            int[] input = new int[] { 1, -1, 5, 7, 3, 9, 10 };
            int value = 0;

            List<int> actual = target.FindClosest3Sum(input, value);
            Assert.IsTrue(actual.Contains(1), "contains 1");
            Assert.IsTrue(actual.Contains(-1), "contains -1");
            Assert.IsTrue(actual.Contains(3), "contains 3");

            input = new int[] { 2, -1, 5, 7, 3, 9, -10 };
            value = 0;
            actual = target.FindClosest3Sum(input, value);

            Assert.IsTrue(actual.Contains(7), "contains 7");
            Assert.IsTrue(actual.Contains(-10), "contains -10");
            Assert.IsTrue(actual.Contains(3), "contains 3");

            input = new int[] { 2, -1 };
            value = 0;
            actual = target.FindClosest3Sum(input, value);
            Assert.AreEqual(0, actual.Count, "Should contains no retsult");
        }

        /// <summary>
        ///A test for Find4Sum
        ///</summary>
        [TestMethod()]
        public void Find4SumTest()
        {
            _002_Find3Sum_Round2 target = new _002_Find3Sum_Round2(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { -3, -1, 0, 2, 4, 5 };
            List<List<int>> actual = target.Find4Sum(input);
            Assert.AreEqual(1, actual.Count);

            input = new int[] { -3, -2, -1, 0, 0, 1, 2, 3 };
            List<int> tmp1 = new List<int>() { -3, -2, 2, 3 };
            List<int> tmp2 = new List<int>() { -3, -1, 1, 3 };
            List<int> tmp3 = new List<int>() { -3, 0, 0, 3 };
            List<int> tmp4 = new List<int>() { -3, 0, 1, 2 };
            List<int> tmp5 = new List<int>() { -2, -1, 0, 3 };
            List<int> tmp6 = new List<int>() { -2, -1, 1, 2 };
            List<int> tmp7 = new List<int>() { -2, 0, 0, 2 };
            List<int> tmp8 = new List<int>() { -1, 0, 0, 1 };
            List<List<int>> expected = new List<List<int>>() { tmp1, tmp2, tmp3, tmp4, tmp5, tmp6, tmp7, tmp8 };
            actual = target.Find4Sum(input);
            Assert.AreEqual(expected.Count, actual.Count);
        }
    }
}
