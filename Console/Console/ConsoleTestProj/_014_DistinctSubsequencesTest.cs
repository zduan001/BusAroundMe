using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _014_DistinctSubsequencesTest and is intended
    ///to contain all _014_DistinctSubsequencesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _014_DistinctSubsequencesTest
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
        ///A test for NumberDistinct
        ///</summary>
        [TestMethod()]
        public void NumberDistinctTest()
        {
            _014_DistinctSubsequences target = new _014_DistinctSubsequences(); // TODO: Initialize to an appropriate value
            string s = "rabbbit"; // TODO: Initialize to an appropriate value
            string t = "rabbit"; // TODO: Initialize to an appropriate value
            int expected = 3; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.NumberDistinct(s, t);
            Assert.AreEqual(expected, actual);
        }
    }
}
