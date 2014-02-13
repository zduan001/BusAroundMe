using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _036_MinSumPathTest and is intended
    ///to contain all _036_MinSumPathTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _036_MinSumPathTest
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
        ///A test for FindMinSumPathRecursive
        ///</summary>
        [TestMethod()]
        public void FindMinSumPathRecursiveTest()
        {
            _036_MinSumPath target = new _036_MinSumPath(); // TODO: Initialize to an appropriate value
            int[,] input = new[,] { {1,3,1},{1,5,1},{4,2,1}};
            int expected = 7; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.FindMinSumPathRecursive(input);
            Assert.AreEqual(expected, actual);
            
        }
    }
}
