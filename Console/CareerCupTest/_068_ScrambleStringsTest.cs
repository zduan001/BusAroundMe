using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _068_ScrambleStringsTest and is intended
    ///to contain all _068_ScrambleStringsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _068_ScrambleStringsTest
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
        ///A test for VerifyIsScrambleStrings
        ///</summary>
        [TestMethod()]
        public void VerifyIsScrambleStringsTest()
        {
            _068_ScrambleStrings target = new _068_ScrambleStrings(); // TODO: Initialize to an appropriate value
            string s1 = "dcba";
            string s2 = "abcd";
            bool expected = true; 
            bool actual;
            actual = target.VerifyIsScrambleStrings(s1, s2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ScrambleString
        ///</summary>
        [TestMethod()]
        public void ScrambleStringTest()
        {
            string s1 = "dcba";
            string s2 = "abcd";
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = _068_ScrambleStrings.ScrambleString(s1, s2);
            Assert.AreEqual(expected, actual);
        }
    }
}
