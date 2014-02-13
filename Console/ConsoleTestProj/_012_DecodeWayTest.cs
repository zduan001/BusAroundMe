using Console2.From_001_To_025;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _012_DecodeWayTest and is intended
    ///to contain all _012_DecodeWayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _012_DecodeWayTest
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
        ///A test for DecodeTheWay
        ///</summary>
        [TestMethod()]
        public void DecodeTheWayTest()
        {
            _012_DecodeWay target = new _012_DecodeWay(); // TODO: Initialize to an appropriate value
            int n = 81195; 
            int expected = 3; 
            int actual = target.DecodeTheWay(n);
            Assert.AreEqual(expected, actual);

            n = 811905;
            expected = 0;
            actual = target.DecodeTheWay(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
