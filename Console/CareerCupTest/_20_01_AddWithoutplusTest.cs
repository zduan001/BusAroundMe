using CareerCup150.Chapter20_hard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _20_01_AddWithoutplusTest and is intended
    ///to contain all _20_01_AddWithoutplusTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _20_01_AddWithoutplusTest
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
        ///A test for Add
        ///</summary>
        [TestMethod()]
        public void AddTest()
        {
            _20_01_AddWithoutplus target = new _20_01_AddWithoutplus(); // TODO: Initialize to an appropriate value
            int number1 = 123; // TODO: Initialize to an appropriate value
            int number2 = 345; // TODO: Initialize to an appropriate value
            int expected = 468; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Add(number1, number2);
            Assert.AreEqual(expected, actual);
        }
    }
}
