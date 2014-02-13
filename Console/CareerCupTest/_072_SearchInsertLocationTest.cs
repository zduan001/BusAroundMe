using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _072_SearchInsertLocationTest and is intended
    ///to contain all _072_SearchInsertLocationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _072_SearchInsertLocationTest
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
        ///A test for SearchInsertIndex
        ///</summary>
        [TestMethod()]
        public void SearchInsertIndexTest()
        {
            /*
             *          
             [1,3,5,6], 5 → 2
             [1,3,5,6], 2 → 1
             [1,3,5,6], 7 → 4
             [1,3,5,6], 0 → 0 
            */
            _072_SearchInsertLocation target = new _072_SearchInsertLocation(); // TODO: Initialize to an appropriate value
            int[] input = new int[] {1,3,5,6 };
            int value = 5; // TODO: Initialize to an appropriate value
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.SearchInsertIndex(input, value);
            Assert.AreEqual(expected, actual);

            value = 2; // TODO: Initialize to an appropriate value
            expected = 1; // TODO: Initialize to an appropriate value
            actual = target.SearchInsertIndex(input, value);
            Assert.AreEqual(expected, actual);


            value = 7; // TODO: Initialize to an appropriate value
            expected = 4; // TODO: Initialize to an appropriate value
            actual = target.SearchInsertIndex(input, value);
            Assert.AreEqual(expected, actual);


            value = 0; // TODO: Initialize to an appropriate value
            expected = 0; // TODO: Initialize to an appropriate value
            actual = target.SearchInsertIndex(input, value);
            Assert.AreEqual(expected, actual);
            
        }
    }
}
