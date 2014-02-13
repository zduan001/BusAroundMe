using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _050_MaxSubArrayTest and is intended
    ///to contain all _050_MaxSubArrayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _050_MaxSubArrayTest
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
            _050_MaxSubArray target = new _050_MaxSubArray(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 31, -41, 59, 26, -53, 58, 97, -93, -23, 84 };
            int startIndex = 0; // TODO: Initialize to an appropriate value
            int startIndexExpected = 2; // TODO: Initialize to an appropriate value
            int endIndex = 0; // TODO: Initialize to an appropriate value
            int endIndexExpected = 6; // TODO: Initialize to an appropriate value
            int expected = 187; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.MaxSubArray(input, ref startIndex, ref endIndex);
            Assert.AreEqual(startIndexExpected, startIndex);
            Assert.AreEqual(endIndexExpected, endIndex);
            Assert.AreEqual(expected, actual);
        }
    }
}
