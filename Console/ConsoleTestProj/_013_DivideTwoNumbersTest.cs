using Console2.From_001_To_025;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _013_DivideTwoNumbersTest and is intended
    ///to contain all _013_DivideTwoNumbersTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _013_DivideTwoNumbersTest
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
        ///A test for DivideTwoNumbers
        ///</summary>
        [TestMethod()]
        public void DivideTwoNumbersTest()
        {
            // -1213556684, 51465006 0 -23 
            _013_DivideTwoNumbers target = new _013_DivideTwoNumbers(); // TODO: Initialize to an appropriate value
            int dividor = -1213556684; 
            int divident = 51465006; 
            int expected = -23;
            int actual = target.DivideTwoNumbers(dividor, divident);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for DivideTwoNumberII
        ///</summary>
        [TestMethod()]
        public void DivideTwoNumberIITest()
        {
            _013_DivideTwoNumbers target = new _013_DivideTwoNumbers(); // TODO: Initialize to an appropriate value
            int dividor = -1213556684;
            int divident = 51465006;
            int expected = -23;
            int actual = target.DivideTwoNumberII(dividor, divident);
            Assert.AreEqual(expected, actual);
        }
    }
}
