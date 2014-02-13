using CareerCup150.Chapt1_ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _01_02_ReverseStringTest and is intended
    ///to contain all _01_02_ReverseStringTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _01_02_ReverseStringTest
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
        ///A test for ReverseStr
        ///</summary>
        [TestMethod()]
        public void ReverseStrTest()
        {
            _01_02_ReverseString target = new _01_02_ReverseString(); // TODO: Initialize to an appropriate value
            string s = "abcdefg";
            string expected = "gfedcba";
            string actual = target.ReverseStr(s);
            Assert.AreEqual(expected, actual);

            s = "abcdeefg";
            expected = "gfeedcba";
            actual = target.ReverseStr(s);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ReverseStrWhileLoop
        ///</summary>
        [TestMethod()]
        public void ReverseStrWhileLoopTest()
        {
            _01_02_ReverseString target = new _01_02_ReverseString(); // TODO: Initialize to an appropriate value
            string s = "abcdefg";
            string expected = "gfedcba";
            string actual = target.ReverseStrWhileLoop(s);
            Assert.AreEqual(expected, actual);

            s = "abcdeefg";
            expected = "gfeedcba";
            actual = target.ReverseStrWhileLoop(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
