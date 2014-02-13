using Console2.From_076_To_100;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _086_UniqueBinaryTreeTest and is intended
    ///to contain all _086_UniqueBinaryTreeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _086_UniqueBinaryTreeTest
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
        ///A test for UniqueBinaryTree
        ///</summary>
        [TestMethod()]
        public void UniqueBinaryTreeTest()
        {
            _086_UniqueBinaryTree target = new _086_UniqueBinaryTree(); // TODO: Initialize to an appropriate value
            int start = 1;
            int end = 3;
            int expected = 5; 
            int actual;
            actual = target.UniqueBinaryTree(start, end);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for UniqueBinaryTreeII
        ///</summary>
        [TestMethod()]
        public void UniqueBinaryTreeIITest()
        {
            _086_UniqueBinaryTree target = new _086_UniqueBinaryTree(); // TODO: Initialize to an appropriate value
            int n = 3; // TODO: Initialize to an appropriate value
            int expected = 5;
            int actual;
            actual = target.UniqueBinaryTreeII(n);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AllBSTs
        ///</summary>
        [TestMethod()]
        public void AllBSTsTest()
        {
            _086_UniqueBinaryTree target = new _086_UniqueBinaryTree(); // TODO: Initialize to an appropriate value
            int start = 1;
            int end = 3;
            List<TreeNode> actual;
            actual = target.AllBSTs(start, end);
            Assert.AreEqual(5, actual.Count);
        }
    }
}
