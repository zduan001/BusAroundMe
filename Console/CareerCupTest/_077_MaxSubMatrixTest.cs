using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _077_MaxSubMatrixTest and is intended
    ///to contain all _077_MaxSubMatrixTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _077_MaxSubMatrixTest
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
        ///A test for FindMaxSubMatrix
        ///</summary>
        [TestMethod()]
        public void FindMaxSubMatrixTest()
        {
            _077_MaxSubMatrix target = new _077_MaxSubMatrix(); // TODO: Initialize to an appropriate value
            int[,] input = new int[,] {{0,1,1,0,1},{1,1,0,1,0},{0,1,1,1,0},{1,1,1,1,0},{1,1,1,1,1},{0,0,0,0,0} };
            int expected = 9;
            int actual;
            actual = target.FindMaxSubMatrix(input);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for FindMaxSubMatrixDP
        ///</summary>
        [TestMethod()]
        public void FindMaxSubMatrixDPTest()
        {
            _077_MaxSubMatrix target = new _077_MaxSubMatrix(); // TODO: Initialize to an appropriate value
            int[,] input = new int[,] { { 0, 1, 1, 0, 1 }, { 1, 1, 0, 1, 0 }, { 0, 1, 1, 1, 0 }, { 1, 1, 1, 1, 0 }, { 1, 1, 1, 1, 1 }, { 0, 0, 0, 0, 0 } };
            int expected = 9;
            int actual;
            actual = target.FindMaxSubMatrixDP(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
