using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _075_SpiralMatrixTest and is intended
    ///to contain all _075_SpiralMatrixTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _075_SpiralMatrixTest
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
        ///A test for PrintOutMatrixSpiral
        ///</summary>
        [TestMethod()]
        public void PrintOutMatrixSpiralTest()
        {
            _075_SpiralMatrix target = new _075_SpiralMatrix(); // TODO: Initialize to an appropriate value
            int[,] input = new int[,] {{1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }};
            List<int> expected = new List<int>(){1,2,3,6,9,8,7,4,5};
            List<int> actual;
            actual = target.PrintOutMatrixSpiral(input);
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        /// <summary>
        ///A test for GenerateSpiralMatrix
        ///</summary>
        [TestMethod()]
        public void GenerateSpiralMatrixTest()
        {
            _075_SpiralMatrix target = new _075_SpiralMatrix(); // TODO: Initialize to an appropriate value
            int n = 3;
            int[,] expected = new int[,] { { 1, 2, 3 },{ 8, 9, 4 },{ 7, 6, 5 }};
            int[,] actual;
            actual = target.GenerateSpiralMatrix(n);
            
            Assert.AreEqual(expected.GetLength(0), actual.GetLength(0));
            Assert.AreEqual(expected.GetLength(1), actual.GetLength(1));
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
            }
        }
    }
}
