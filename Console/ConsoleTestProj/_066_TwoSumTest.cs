using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _066_TwoSumTest and is intended
    ///to contain all _066_TwoSumTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _066_TwoSumTest
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
        ///A test for TwoSum
        ///</summary>
        [TestMethod()]
        public void TwoSumTest()
        {
            _066_TwoSum target = new _066_TwoSum(); // TODO: Initialize to an appropriate value
            List<int> numbers = new List<int>() {2, 7, 11, 15};
            int value = 9; // TODO: Initialize to an appropriate value
            List<int> actual;
            actual = target.TwoSum(numbers, value);
            Assert.IsTrue(actual.Contains(1));
            Assert.IsTrue(actual.Contains(0));

            value = 1000; // TODO: Initialize to an appropriate value
            actual = target.TwoSum(numbers, value);
            Assert.IsNull(actual);
        }
    }
}
