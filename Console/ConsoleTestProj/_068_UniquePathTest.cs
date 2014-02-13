using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _068_UniquePathTest and is intended
    ///to contain all _068_UniquePathTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _068_UniquePathTest
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
        ///A test for UniquePaths
        ///</summary>
        [TestMethod()]
        public void UniquePathsTest()
        {
            _068_UniquePath target = new _068_UniquePath(); // TODO: Initialize to an appropriate value
            int m = 10; // TODO: Initialize to an appropriate value
            int n = 10; // TODO: Initialize to an appropriate value
            int expected = 48620; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.UniquePaths(m, n);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for UniquePathsII
        ///</summary>
        [TestMethod()]
        public void UniquePathsIITest()
        {
            _068_UniquePath target = new _068_UniquePath(); 
            int m = 3; 
            int n = 3; 
            int k = 1; 
            int l = 1; 
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.UniquePathsII(m, n, k, l);
            Assert.AreEqual(expected, actual);
        }
    }
}
