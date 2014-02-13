using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _009DecodeWayTest and is intended
    ///to contain all _009DecodeWayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _009DecodeWayTest
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
        ///A test for DecodeWays
        ///</summary>
        [TestMethod()]
        public void DecodeWaysTest()
        {
            _009DecodeWay target = new _009DecodeWay(); // TODO: Initialize to an appropriate value
            string input;
            int expected;
            int actual;


            input = "226";
            expected = 3;
            actual = target.DecodeWays(input);
            Assert.AreEqual(expected, actual);


            input = "4854154937399897379975613984238125355884258369243193936685559588342434968134474812375281371442336859";
            expected = 18432;
            actual = target.DecodeWays(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
