using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _016_ImplementStrStrTest and is intended
    ///to contain all _016_ImplementStrStrTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _016_ImplementStrStrTest
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
        ///A test for FindStrInStr
        ///</summary>
        [TestMethod()]
        public void FindStrInStrTest()
        {
            _016_ImplementStrStr target = new _016_ImplementStrStr(); // TODO: Initialize to an appropriate value
            string haystack = "abcde"; // TODO: Initialize to an appropriate value
            string needle = "cd"; // TODO: Initialize to an appropriate value
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.FindStrInStr(haystack, needle);
            Assert.AreEqual(expected, actual);

            haystack = "hello"; ; // TODO: Initialize to an appropriate value
            needle = "lo"; // TODO: Initialize to an appropriate value
            expected = 3; // TODO: Initialize to an appropriate value
            actual = target.FindStrInStr(haystack, needle);
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for FindStrStrZAlgorithm
        ///</summary>
        [TestMethod()]
        public void FindStrStrZAlgorithmTest()
        {
            _016_ImplementStrStr target = new _016_ImplementStrStr(); // TODO: Initialize to an appropriate value
            string haystack = "abcde"; // TODO: Initialize to an appropriate value
            string needle = "cd"; // TODO: Initialize to an appropriate value
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.FindStrStrZAlgorithm(haystack, needle);
            Assert.AreEqual(expected, actual);

            haystack = "hello"; ; // TODO: Initialize to an appropriate value
            needle = "lo"; // TODO: Initialize to an appropriate value
            expected = 3; // TODO: Initialize to an appropriate value
            actual = target.FindStrStrZAlgorithm(haystack, needle);
            Assert.AreEqual(expected, actual);
        }
    }
}
