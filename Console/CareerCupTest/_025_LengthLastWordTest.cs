using Console2.From_001_To_025;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _025_LengthLastWordTest and is intended
    ///to contain all _025_LengthLastWordTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _025_LengthLastWordTest
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
        ///A test for FindLengthOfLastWord
        ///</summary>
        [TestMethod()]
        public void FindLengthOfLastWordTest()
        {
            _025_LengthLastWord target = new _025_LengthLastWord(); // TODO: Initialize to an appropriate value
            string s = "Hello World";
            int expected = 5; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.FindLengthOfLastWord(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
