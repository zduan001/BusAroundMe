using CareerCup150.Chapter9_SortingSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _09_05_EmtpyStringsTest and is intended
    ///to contain all _09_05_EmtpyStringsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _09_05_EmtpyStringsTest
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
        ///A test for FindString
        ///</summary>
        [TestMethod()]
        public void FindStringTest()
        {
            _09_05_EmtpyStrings target = new _09_05_EmtpyStrings(); // TODO: Initialize to an appropriate value
            string[] input = new string[] {"at", "", "", "", "ball", "", "", "car", "", "", "dad", "", "" };
            string value = "ball";
            int expected = 4;
            int actual = target.FindString(input, value);
            Assert.AreEqual(expected, actual);

            value = "car";
            expected = 7;
            actual = target.FindString(input, value);
            Assert.AreEqual(expected, actual);

            value = "ballcar";
            expected = -1;
            actual = target.FindString(input, value);
            Assert.AreEqual(expected, actual);
        }
    }
}
