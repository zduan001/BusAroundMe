using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _038_MultiplyStringsTest and is intended
    ///to contain all _038_MultiplyStringsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _038_MultiplyStringsTest
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
        ///A test for Multiply
        ///</summary>
        [TestMethod()]
        public void MultiplyTest()
        {
            _038_MultiplyStrings target = new _038_MultiplyStrings(); // TODO: Initialize to an appropriate value
            string s1 = "123";
            string s2 = "34";
            string expected = "30831";
            string actual;
            actual = target.Multiply(s1, s2);
            Assert.AreEqual(expected, actual);
        }
    }
}
