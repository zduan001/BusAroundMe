using Console2.From_001_To_025;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _018_StrInStrTest and is intended
    ///to contain all _018_StrInStrTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _018_StrInStrTest
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
        ///A test for StrInStr
        ///</summary>
        [TestMethod()]
        public void StrInStrTest()
        {
            _018_StrInStr target = new _018_StrInStr();
            string haystack = "abcde"; 
            string needle = "cd";
            int expected = 2;
            int actual;
            actual = target.StrInStr(haystack, needle);
            Assert.AreEqual(expected, actual);

            haystack = "hello";
            needle = "lo"; 
            expected = 3; 
            actual = target.StrInStr(haystack, needle);
            Assert.AreEqual(expected, actual);
        }
    }
}
