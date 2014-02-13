using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _026_MaxSubArrayTest and is intended
    ///to contain all _026_MaxSubArrayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _026_MaxSubArrayTest
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
        ///A test for MaxSubArray
        ///</summary>
        [TestMethod()]
        public void MaxSubArrayTest()
        {
            _026_MaxSubArray target = new _026_MaxSubArray(); 
            int[] input = new int[] {-2,1,-3,4,-1,2,1,-5,4};
            int expected = 6;
            int actual;
            actual = target.MaxSubArray(input);
            Assert.AreEqual(expected, actual);

            //-9,9,7,-8,-3,2,-9,1,7,-2,-9,7,-9,5,5,-3,9,0
            input = new int[] { -9, 9, 7, -8, -3, 2, -9, 1, 7, -2, -9, 7, -9, 5, 5, -3, 9, 0 };
            expected = 16;
            actual = target.MaxSubArray(input);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for MaxSubArrayRecursive
        ///</summary>
        [TestMethod()]
        public void MaxSubArrayRecursiveTest()
        {
            _026_MaxSubArray target = new _026_MaxSubArray();
            int[] input = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int expected = 6;
            int actual;
            actual = target.MaxSubArrayRecursive(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
