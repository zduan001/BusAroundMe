using Console2.From_001_To_025;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _023_JumpGameTest and is intended
    ///to contain all _023_JumpGameTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _023_JumpGameTest
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
        ///A test for JumpGame
        ///</summary>
        [TestMethod()]
        public void JumpGameTest()
        {
            _023_JumpGame target = new _023_JumpGame(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 2, 3, 1, 1, 4 };
            bool expected = true;
            bool actual = target.JumpGame(input);
            Assert.AreEqual(expected, actual);

            input = new int[] { 3, 2, 1, 0, 4 };
            expected = false;
            actual = target.JumpGame(input);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for JumpGame2
        ///</summary>
        [TestMethod()]
        public void JumpGame2Test()
        {
            _023_JumpGame target = new _023_JumpGame(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 2, 3, 1, 1, 4 };
            int expected = 2; 
            int actual;
            actual = target.JumpGame2(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
