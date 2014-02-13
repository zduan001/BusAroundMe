using CareerCup150.Chapter9_SortingSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _09_03_RotateArrayTest and is intended
    ///to contain all _09_03_RotateArrayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _09_03_RotateArrayTest
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
        ///A test for FindInRotateArray
        ///</summary>
        [TestMethod()]
        public void FindInRotateArrayTest()
        {
            _09_03_RotateArray target = new _09_03_RotateArray(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 4,5,6,7,8,9,10,11,12,125,1,2,3};
            int value = 1; // TODO: Initialize to an appropriate value
            int expected = 10; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.FindInRotateArray(input, value);
            Assert.AreEqual(expected, actual);

            value = 125; // TODO: Initialize to an appropriate value
            expected = 9; // TODO: Initialize to an appropriate value
            actual = target.FindInRotateArray(input, value);
            Assert.AreEqual(expected, actual);

            value = 9; // TODO: Initialize to an appropriate value
            expected = 5; // TODO: Initialize to an appropriate value
            actual = target.FindInRotateArray(input, value);
            Assert.AreEqual(expected, actual);
        }
    }
}
