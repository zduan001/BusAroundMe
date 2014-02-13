using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _050_FindInsertLocationTest and is intended
    ///to contain all _050_FindInsertLocationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _050_FindInsertLocationTest
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
        ///A test for FindInsertLocation
        ///</summary>
        [TestMethod()]
        public void FindInsertLocationTest()
        {
            // [1,3,5,6], 5 → 2
            // [1,3,5,6], 2 → 1
            // [1,3,5,6], 7 → 4
            // [1,3,5,6], 0 → 0
            _050_FindInsertLocation target = new _050_FindInsertLocation(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 1, 3, 5, 6 };
            int value = 5; // TODO: Initialize to an appropriate value
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.FindInsertLocation(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 1, 3, 5, 6 };
            value = 2; 
            expected = 1; 
            actual = target.FindInsertLocation(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 1, 3, 5, 6 };
            value = 7;
            expected = 4;
            actual = target.FindInsertLocation(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 1, 3, 5, 6 };
            value = 0;
            expected = 0;
            actual = target.FindInsertLocation(input, value);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for SearchInsertPosition
        ///</summary>
        [TestMethod()]
        public void SearchInsertPositionTest()
        {
            _050_FindInsertLocation target = new _050_FindInsertLocation(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 1, 3, 5, 6 };
            int value = 5; // TODO: Initialize to an appropriate value
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.SearchInsertPosition(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 1, 3, 5, 6 };
            value = 2;
            expected = 1;
            actual = target.SearchInsertPosition(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 1, 3, 5, 6 };
            value = 7;
            expected = 4;
            actual = target.SearchInsertPosition(input, value);
            Assert.AreEqual(expected, actual);

            input = new int[] { 1, 3, 5, 6 };
            value = 0;
            expected = 0;
            actual = target.SearchInsertPosition(input, value);
            Assert.AreEqual(expected, actual);
        }
    }
}
