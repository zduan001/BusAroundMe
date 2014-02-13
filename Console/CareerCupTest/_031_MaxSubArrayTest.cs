using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _031_MaxSubArrayTest and is intended
    ///to contain all _031_MaxSubArrayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _031_MaxSubArrayTest
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
        ///A test for FindMaxSubArray
        ///</summary>
        [TestMethod()]
        public void FindMaxSubArrayTest()
        {
            _031_MaxSubArray target = new _031_MaxSubArray(); // TODO: Initialize to an appropriate value
            int[] input = new int[] {-2,1,-3,4,-1,2,1,-5,4};
            int expected = 6;
            int actual;
            actual = target.FindMaxSubArray(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
