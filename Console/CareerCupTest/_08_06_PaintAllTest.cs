using CareerCup150.Chapter8_Recursion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _08_06_PaintAllTest and is intended
    ///to contain all _08_06_PaintAllTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _08_06_PaintAllTest
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
        ///A test for PaintAll
        ///</summary>
        [TestMethod()]
        public void PaintAllTest()
        {
            _08_06_PaintAll target = new _08_06_PaintAll(); // TODO: Initialize to an appropriate value
            int[,] input = new int[,] { { 1, 2, 3, 4, 5, 6 }, { 1, 2, 3, 4, 5, 6 }, { 1, 2, 9, 9, 9, 9 }, { 9, 9, 9, 9, 5, 6 }, { 1, 2, 3, 4, 5, 6 }, { 1, 2, 3, 4, 5, 6 } };
            int i = 2; 
            int j = 2; 
            int color = 100; // TODO: Initialize to an appropriate value
            target.PaintAll(input, i, j, color);
        }
    }
}
