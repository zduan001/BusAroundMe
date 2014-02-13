using Console2.From_076_To_100;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CareerCupTest
{


    /// <summary>
    ///This is a test class for _085_MinTriangleTest and is intended
    ///to contain all _085_MinTriangleTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _085_MinTriangleTest
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
        ///A test for FindMinTriangle
        ///</summary>
        [TestMethod()]
        public void FindMinTriangleTest()
        {
            _085_MinTriangle target = new _085_MinTriangle(); // TODO: Initialize to an appropriate value

            List<int> tmp1 = new List<int>() { 2 };
            List<int> tmp2 = new List<int>() { 3, 4 };
            List<int> tmp3 = new List<int>() { 6, 5, 7 };
            List<int> tmp4 = new List<int>() { 4, 1, 8, 3 };

            List<List<int>> input = new List<List<int>>() { tmp1, tmp2, tmp3, tmp4 };
            int expected = 11; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.FindMinTriangle(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
