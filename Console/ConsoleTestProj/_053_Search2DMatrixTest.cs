using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _053_Search2DMatrixTest and is intended
    ///to contain all _053_Search2DMatrixTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _053_Search2DMatrixTest
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
        ///A test for Search2DMatrix
        ///</summary>
        [TestMethod()]
        public void Search2DMatrixTest()
        {

            /// [ 
            /// [1, 3, 5, 7], 
            /// [10, 11, 16, 20], 
            /// [23, 30, 34, 50]
            /// ]
            _053_Search2DMatrix target = new _053_Search2DMatrix(); // TODO: Initialize to an appropriate value
            List<int> tmp1 = new List<int>() { 1, 3, 5, 7 };
            List<int> tmp2 = new List<int>() { 10, 11, 16, 20 };
            List<int> tmp3 = new List<int>() { 21, 22, 23, 24 };
            List<int> tmp4 = new List<int>() { 33, 30, 34, 50 };
            List<int> tmp5 = new List<int>() { 100, 102, 120, 145 };
            List<List<int>> input = new List<List<int>>() { tmp1, tmp2, tmp3,tmp4, tmp5 };
            int value = 17; 
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Search2DMatrix(input, value);
            Assert.AreEqual(expected, actual);

            value = 16;
            expected = true;
            actual = target.Search2DMatrix(input, value);
            Assert.AreEqual(expected, actual);

            value = 145;
            expected = true;
            actual = target.Search2DMatrix(input, value);
            Assert.AreEqual(expected, actual);

            value = 1;
            expected = true;
            actual = target.Search2DMatrix(input, value);
            Assert.AreEqual(expected, actual);


            value = 160;
            expected = false;
            actual = target.Search2DMatrix(input, value);
            Assert.AreEqual(expected, actual);
        }
    }
}
