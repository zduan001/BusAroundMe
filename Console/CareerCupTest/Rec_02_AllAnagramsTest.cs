using Console2.recursion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for Rec_02_AllAnagramsTest and is intended
    ///to contain all Rec_02_AllAnagramsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class Rec_02_AllAnagramsTest
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
        ///A test for CrackPassword
        ///</summary>
        [TestMethod()]
        public void CrackPasswordTest()
        {
            Rec_02_AllAnagrams target = new Rec_02_AllAnagrams(); // TODO: Initialize to an appropriate value
            string password = "ABCA22";
            bool expected = true;
            bool actual = target.CrackPassword(password);
            Assert.AreEqual(expected, actual);
        }
    }
}
