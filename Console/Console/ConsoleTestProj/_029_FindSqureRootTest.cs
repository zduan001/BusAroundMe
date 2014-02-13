using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _029_FindSqureRootTest and is intended
    ///to contain all _029_FindSqureRootTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _029_FindSqureRootTest
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
        ///A test for FindSqrt
        ///</summary>
        [TestMethod()]
        public void FindSqrtTest()
        {
            _029_FindSqureRoot target = new _029_FindSqureRoot(); // TODO: Initialize to an appropriate value
            double input = 64; // TODO: Initialize to an appropriate value
            double expected = 8; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.FindSqrt(input);
            Assert.AreEqual(expected, actual);

            input = 144; // TODO: Initialize to an appropriate value
            expected = 12; // TODO: Initialize to an appropriate value
            actual = target.FindSqrt(input);
            Assert.IsTrue(Math.Abs(expected- actual) < 0.0001);

            input = 0.64;
            expected = 0.8; 
            actual = target.FindSqrt(input);
            Assert.IsTrue(Math.Abs(expected - actual) < 0.0001);
        }
    }
}
