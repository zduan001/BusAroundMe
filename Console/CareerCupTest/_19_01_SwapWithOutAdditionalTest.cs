using CareerCup150.Chapter9_SortingSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _19_01_SwapWithOutAdditionalTest and is intended
    ///to contain all _19_01_SwapWithOutAdditionalTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _19_01_SwapWithOutAdditionalTest
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
        ///A test for Swap
        ///</summary>
        [TestMethod()]
        public void SwapTest()
        {
            _19_01_SwapWithOutAdditional target = new _19_01_SwapWithOutAdditional(); // TODO: Initialize to an appropriate value
            int a = 2; // TODO: Initialize to an appropriate value
            int aExpected = 3; // TODO: Initialize to an appropriate value
            int b = 3; // TODO: Initialize to an appropriate value
            int bExpected = 2; // TODO: Initialize to an appropriate value
            target.Swap(ref a, ref b);
            Assert.AreEqual(aExpected, a);
            Assert.AreEqual(bExpected, b);
            
        }
    }
}
