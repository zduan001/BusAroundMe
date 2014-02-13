using CareerCup150.Chapt1_ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _01_08_CheckRotateStringTest and is intended
    ///to contain all _01_08_CheckRotateStringTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _01_08_CheckRotateStringTest
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
        ///A test for IsRotateString
        ///</summary>
        [TestMethod()]
        public void IsRotateStringTest()
        {
            _01_08_CheckRotateString target = new _01_08_CheckRotateString(); // TODO: Initialize to an appropriate value
            string s1 = "1234567890";
            string s2 = "8901234567";
            bool expected = true;
            bool actual = target.IsRotateString(s1, s2);
            Assert.AreEqual(expected, actual);


            s1 = "1234567890";
            s2 = "89012344567";
            expected = false;
            actual = target.IsRotateString(s1, s2);
            Assert.AreEqual(expected, actual);
        }
    }
}
