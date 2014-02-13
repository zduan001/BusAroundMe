using CareerCup150.Chapt1_ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _01_01_DetermineIfAllUniqueCharsTest and is intended
    ///to contain all _01_01_DetermineIfAllUniqueCharsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _01_01_DetermineIfAllUniqueCharsTest
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
        ///A test for IsUnique
        ///</summary>
        [TestMethod()]
        public void IsUniqueTest()
        {
            _01_01_DetermineIfAllUniqueChars target = new _01_01_DetermineIfAllUniqueChars(); // TODO: Initialize to an appropriate value
            string s = "abcdefg";
            bool expected = true;
            bool actual = target.IsUnique(s);
            Assert.AreEqual(expected, actual);

            s = "abcdefga";
            expected = false;
            actual = target.IsUnique(s);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for IsUniqueNoAdditionalDS
        ///</summary>
        [TestMethod()]
        public void IsUniqueNoAdditionalDSTest()
        {
            _01_01_DetermineIfAllUniqueChars target = new _01_01_DetermineIfAllUniqueChars(); // TODO: Initialize to an appropriate value

            string s = "abcdefg";
            bool expected = true;
            bool actual = target.IsUniqueNoAdditionalDS(s);
            Assert.AreEqual(expected, actual);

            s = "abcdefga";
            expected = false;
            actual = target.IsUniqueNoAdditionalDS(s);
            Assert.AreEqual(expected, actual);

        }
    }
}
