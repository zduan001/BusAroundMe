using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _070_SearchARangeTest and is intended
    ///to contain all _070_SearchARangeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _070_SearchARangeTest
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
        ///A test for FindRange
        ///</summary>
        [TestMethod()]
        public void FindRangeTest()
        {
            _070_SearchARange target = new _070_SearchARange(); // TODO: Initialize to an appropriate value
            int[] input = null; // TODO: Initialize to an appropriate value
            int value = 0; // TODO: Initialize to an appropriate value
            int start = 0; // TODO: Initialize to an appropriate value
            int startExpected = 0; // TODO: Initialize to an appropriate value
            int end = 0; // TODO: Initialize to an appropriate value
            int endExpected = 0; // TODO: Initialize to an appropriate value
            target.FindRange(input, value, ref start, ref end);
            Assert.AreEqual(startExpected, start);
            Assert.AreEqual(endExpected, end);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
