using CareerCup150.Chapt1_ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{


    /// <summary>
    ///This is a test class for _01_07_SetRowColumnTest and is intended
    ///to contain all _01_07_SetRowColumnTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _01_07_SetRowColumnTest
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
        ///A test for SetZero
        ///</summary>
        [TestMethod()]
        public void SetZeroTest()
        {
            _01_07_SetRowColumn target = new _01_07_SetRowColumn(); // TODO: Initialize to an appropriate value
            int[,] input = new int[,] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 0, 4, 5 }, { 1, 2, 3, 4, 5 } };
            int[,] expected = new int[,] { { 1, 2, 0, 4, 5 }, { 1, 2, 0, 4, 5 }, { 0, 0, 0, 0, 0 }, { 1, 2, 0, 4, 5 } };
            int[,] actual = target.SetZero(input);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
            }
        }
    }
}
