using CareerCup150.Chapter4_TreeGraph;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _04_03_CreateMinHeighTreeTest and is intended
    ///to contain all _04_03_CreateMinHeighTreeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _04_03_CreateMinHeighTreeTest
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
        ///A test for CreateMinHeihtTree
        ///</summary>
        [TestMethod()]
        public void CreateMinHeihtTreeTest()
        {
            _04_03_CreateMinHeighTree target = new _04_03_CreateMinHeighTree(); // TODO: Initialize to an appropriate value
            int[] input = new int[] {1,2,3,4,5,6,7,8 };
            TreeNode actual = target.CreateMinHeihtTree(input);
            Assert.AreEqual(4, actual.Value);
            Assert.AreEqual(2, actual.LeftChild.Value);
            Assert.AreEqual(1, actual.LeftChild.LeftChild.Value);
            Assert.AreEqual(3, actual.LeftChild.RightChild.Value);
            Assert.AreEqual(6, actual.RightChild.Value);
            Assert.AreEqual(5, actual.RightChild.LeftChild.Value);
            Assert.AreEqual(7, actual.RightChild.RightChild.Value);
        }
    }
}
