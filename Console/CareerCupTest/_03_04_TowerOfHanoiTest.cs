using CareerCup150.Chapter3_StacksAndQueues;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _03_04_TowerOfHanoiTest and is intended
    ///to contain all _03_04_TowerOfHanoiTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _03_04_TowerOfHanoiTest
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
        ///A test for Hanoi
        ///</summary>
        [TestMethod()]
        public void HanoiTest()
        {
            _03_04_TowerOfHanoi target = new _03_04_TowerOfHanoi();
            int n = 4; 
            target.Hanoi(n);
            for (int i = 1; i <= n; i++)
            {
                Assert.AreEqual(i, target.sArray[2].Pop());
            }
        }
    }
}
