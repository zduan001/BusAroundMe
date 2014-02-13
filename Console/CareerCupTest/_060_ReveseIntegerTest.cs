using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _060_ReveseIntegerTest and is intended
    ///to contain all _060_ReveseIntegerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _060_ReveseIntegerTest
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
        ///A test for ReverseInteger
        ///</summary>
        [TestMethod()]
        public void ReverseIntegerTest()
        {
            _060_ReveseInteger target = new _060_ReveseInteger(); // TODO: Initialize to an appropriate value
            int x = 123; // TODO: Initialize to an appropriate value
            int expected = 321; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.ReverseInteger(x);
            Assert.AreEqual(expected, actual);
        }
    }
}
