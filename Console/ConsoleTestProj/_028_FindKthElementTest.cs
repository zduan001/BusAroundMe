using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _028_FindKthElementTest and is intended
    ///to contain all _028_FindKthElementTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _028_FindKthElementTest
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
        ///A test for FindKthElement
        ///</summary>
        [TestMethod()]
        public void FindKthElementTest()
        {
            _028_FindKthElement target = new _028_FindKthElement(); // TODO: Initialize to an appropriate value
            int[] input = new int[] {5,10,3,9,1,6,4,8,7,2}; // TODO: Initialize to an appropriate value
            int k = 5; // TODO: Initialize to an appropriate value
            int expected = 5; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.FindKthElement(input, k);
            Assert.AreEqual(expected, actual);


            input = new int[] { 5, 10, 3, 9, 1, 6, 4, 8, 7, 2 };
            k = 6;
            expected = 6; 
            actual = target.FindKthElement(input, k);
            Assert.AreEqual(expected, actual);


            input = new int[] { 5, 10, 3, 9, 1, 6, 4, 8, 7, 2 };
            k = 7;
            expected = 7;
            actual = target.FindKthElement(input, k);
            Assert.AreEqual(expected, actual);
        }
    }
}
