using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _045_SpiralMatrixTest and is intended
    ///to contain all _045_SpiralMatrixTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _045_SpiralMatrixTest
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
            _045_SpiralMatrix target = new _045_SpiralMatrix(); 
            int[,] input = new int[,] {{1,2,3},{4,5,6},{7,8,9}}; 
            int m = 3; 
            int n = 3;
            string expected = "1,2,3,6,9,8,7,4,5,";
            string actual;
            actual = target.PrintOutMatrixSpiral(input, m, n);
            Assert.AreEqual(expected, actual);


            input = new int[,] { { 1, 2, 3, 4}, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            m = 4;
            n = 3;
            expected = "1,2,3,4,8,12,11,10,9,5,6,7,";
            actual = target.PrintOutMatrixSpiral(input, m, n);
            Assert.AreEqual(expected, actual);

            input = new int[,] { { 1, 2, 3 }, { 5, 6, 7 }, { 9, 10, 11}, {4, 8, 12} };
            m = 3;
            n = 4;
            expected = "1,2,3,7,11,12,8,4,9,5,6,10,";
            actual = target.PrintOutMatrixSpiral(input, m, n);
            Assert.AreEqual(expected, actual);
        }
    }
}
