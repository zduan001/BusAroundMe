using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _004_ClimbStairsTest and is intended
    ///to contain all _004_ClimbStairsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _004_ClimbStairsTest
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
        ///A test for ClimbStairs
        ///</summary>
        [TestMethod()]
        public void ClimbStairsTest()
        {
            _004_ClimbStairs target = new _004_ClimbStairs(); // TODO: Initialize to an appropriate value
            int n = 3; 
            int expected = 3; 
            int actual;
            actual = target.ClimbStairs(n);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ClimbStairs
        ///</summary>
        [TestMethod()]
        public void ClimbStairsTestBigN()
        {
            _004_ClimbStairs target = new _004_ClimbStairs(); // TODO: Initialize to an appropriate value
            int n = 10;
            int expected = 89; 
            int actual;
            actual = target.ClimbStairs(n);
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///A test for ClimbStarisWithO1
        ///</summary>
        [TestMethod()]
        public void ClimbStarisWithO1TestbigN()
        {
            _004_ClimbStairs target = new _004_ClimbStairs(); 
            int n = 5; 
            int expected = 8;
            int actual;
            actual = target.ClimbStarisWithO1(n);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ClimbStarisWithO1
        ///</summary>
        [TestMethod()]
        public void ClimbStarisWithO1Test()
        {
            _004_ClimbStairs target = new _004_ClimbStairs(); 
            int n = 10; 
            int expected = 89; 
            int actual;
            actual = target.ClimbStarisWithO1(n);
            Assert.AreEqual(expected, actual);
        }

    }
}
