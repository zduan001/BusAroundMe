using Console2.From_001_To_025;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _004_ClimbStairs_Round2Test and is intended
    ///to contain all _004_ClimbStairs_Round2Test Unit Tests
    ///</summary>
    [TestClass()]
    public class _004_ClimbStairs_Round2Test
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
        ///A test for FindNumOfWayClimbStairs
        ///</summary>
        [TestMethod()]
        public void FindNumOfWayClimbStairsTest()
        {
            _004_ClimbStairs_Round2 target = new _004_ClimbStairs_Round2(); // TODO: Initialize to an appropriate value
            int n = 2;
            int expected = 2;
            int actual = target.FindNumOfWayClimbStairs(n);
            Assert.AreEqual(expected, actual);

            n = 5;
            expected = 8;
            actual = target.FindNumOfWayClimbStairs(n);
            Assert.AreEqual(expected, actual);

            n = 10;
            expected = 89; // TODO: Initialize to an appropriate value
            actual = target.FindNumOfWayClimbStairs(n);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for FindNumOfWayClimbStairDP
        ///</summary>
        [TestMethod()]
        public void FindNumOfWayClimbStairDPTest()
        {
            _004_ClimbStairs_Round2 target = new _004_ClimbStairs_Round2(); 
            int n = 2;
            int expected = 2;
            int actual;
            actual = target.FindNumOfWayClimbStairDP(n);
            Assert.AreEqual(expected, actual);

            n = 5;
            expected = 8;
            actual = target.FindNumOfWayClimbStairDP(n);
            Assert.AreEqual(expected, actual);

            n = 10;
            expected = 89; // TODO: Initialize to an appropriate value
            actual = target.FindNumOfWayClimbStairDP(n);
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for FindNumOfWayClimbStairDP_O1_Space
        ///</summary>
        [TestMethod()]
        public void FindNumOfWayClimbStairDP_O1_SpaceTest()
        {
            _004_ClimbStairs_Round2 target = new _004_ClimbStairs_Round2(); 
            int n = 2;
            int expected = 2;
            int actual;
            actual = target.FindNumOfWayClimbStairDP_O1_Space(n);
            Assert.AreEqual(expected, actual);

            n = 5;
            expected = 8;
            actual = target.FindNumOfWayClimbStairDP_O1_Space(n);
            Assert.AreEqual(expected, actual);

            n = 10;
            expected = 89; // TODO: Initialize to an appropriate value
            actual = target.FindNumOfWayClimbStairDP_O1_Space(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
