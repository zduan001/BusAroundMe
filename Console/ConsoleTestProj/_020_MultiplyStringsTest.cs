using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{


    /// <summary>
    ///This is a test class for _020_MultiplyStringsTest and is intended
    ///to contain all _020_MultiplyStringsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _020_MultiplyStringsTest
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
        ///A test for MultiplyStrings
        ///</summary>
        [TestMethod()]
        public void MultiplyStringsTest()
        {
            _020_MultiplyStrings target = new _020_MultiplyStrings(); // TODO: Initialize to an appropriate value
            string s1 = "9";
            string s2 = "98";
            string expected = "882"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.MultiplyStrings(s1, s2);
            Assert.AreEqual(expected, actual);

            s1 = "123456789";
            s2 = "987654321";
            expected = "121932631112635269"; // TODO: Initialize to an appropriate value
            actual = target.MultiplyStrings(s1, s2);
            Assert.AreEqual(expected, actual);
        }
    }
}
