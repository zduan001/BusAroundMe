using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _057_RemoveDupFromSortedArrayTest and is intended
    ///to contain all _057_RemoveDupFromSortedArrayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _057_RemoveDupFromSortedArrayTest
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
        ///A test for RemoveDup
        ///</summary>
        [TestMethod()]
        public void RemoveDupTest()
        {
            _057_RemoveDupFromSortedArray target = new _057_RemoveDupFromSortedArray(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { -50, -50, -49, -48, -47, -47, -47, -46, -45, -43, -42, -41, -40, -40, -40, -40, -40, -40, -39, -38, -38, -38, -38, -37, -36, -35, -34, -34, -34, -33, -32, -31, -30, -28, -27, -26, -26, -26, -25, -25, -24, -24, -24, -22, -22, -21, -21, -21, -21, -21, -20, -19, -18, -18, -18, -17, -17, -17, -17, -17, -16, -16, -15, -14, -14, -14, -13, -13, -12, -12, -10, -10, -9, -8, -8, -7, -7, -6, -5, -4, -4, -4, -3, -1, 1, 2, 2, 3, 4, 5, 6, 6, 7, 8, 8, 9, 9, 10, 10, 10, 11, 11, 12, 12, 13, 13, 13, 14, 14, 14, 15, 16, 17, 17, 18, 20, 21, 22, 22, 22, 23, 23, 25, 26, 28, 29, 29, 29, 30, 31, 31, 32, 33, 34, 34, 34, 36, 36, 37, 37, 38, 38, 38, 39, 40, 40, 40, 41, 42, 42, 43, 43, 44, 44, 45, 45, 45, 46, 47, 47, 47, 47, 48, 49, 49, 49, 50 };
            int[] output = new int[] { -50, -49, -48, -47, -46, -45, -43, -42, -41, -40, -39, -38, -37, -36, -35, -34, -33, -32, -31, -30, -28, -27, -26, -25, -24, -22, -21, -20, -19, -18, -17, -16, -15, -14, -13, -12, -10, -9, -8, -7, -6, -5, -4, -3, -1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 20, 21, 22, 23, 25, 26, 28, 29, 30, 31, 32, 33, 34, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
            int actual;
            actual = target.RemoveDup(input);
            Assert.AreEqual(output.Length, actual+1);
            for (int i = 0; i < output.Length; i++)
            {
                Assert.AreEqual(output[i], input[i]);
            }
        }

        /// <summary>
        ///A test for RemoveDupII
        ///</summary>
        [TestMethod()]
        public void RemoveDupIITest()
        {
            _057_RemoveDupFromSortedArray target = new _057_RemoveDupFromSortedArray(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 1, 1, 1, 2, 2, 2, 3, 3 };
            int[] output = new int[] { 1, 1, 2, 2, 3, 3 };
            int actual;
            actual = target.RemoveDupII(input);
            Assert.AreEqual(output.Length, actual + 1);
            for (int i = 0; i < output.Length; i++)
            {
                Assert.AreEqual(output[i], input[i]);
            }
        }
    }
}
