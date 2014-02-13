using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _052_SearchForARangeTest and is intended
    ///to contain all _052_SearchForARangeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _052_SearchForARangeTest
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
        ///A test for SearchForARange
        ///</summary>
        [TestMethod()]
        public void SearchForARangeTest()
        {
            _052_SearchForARange target = new _052_SearchForARange(); // TODO: Initialize to an appropriate value
            int[] input = new int[] {1,2,3,3, 4, 4, 4, 5, 6, 7, 8, 8, 100};
            int value = 8;
            List<int> expected = new List<int>() { 10, 11 };
            List<int> actual;
            actual = target.SearchForARange(input, value);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

            input = new int[] { 1, 2, 3, 3, 4, 4, 4, 5, 6, 7, 8, 8, 100 };
            value = 3;
            expected = new List<int>() { 2, 3 };
            actual = target.SearchForARange(input, value);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

            input = new int[] { 1, 2, 3, 3, 4, 4, 4, 5, 6, 7, 8, 8, 100 };
            value = 4;
            expected = new List<int>() { 4, 6 };
            actual = target.SearchForARange(input, value);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

            input = new int[] { 1, 2, 3, 3, 4, 4, 4, 5, 6, 7, 8, 8, 100 };
            value = 1;
            expected = new List<int>() { 0, 0 };
            actual = target.SearchForARange(input, value);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

            input = new int[] { 1, 2, 3, 3, 4, 4, 4, 5, 6, 7, 8, 8, 100 };
            value = 5;
            expected = new List<int>() { 7, 7 };
            actual = target.SearchForARange(input, value);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }


        }
    }
}
