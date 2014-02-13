using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _051_FindPathSumTest and is intended
    ///to contain all _051_FindPathSumTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _051_FindPathSumTest
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
        ///A test for FindPathSum
        ///</summary>
        [TestMethod()]
        public void FindPathSumTest()
        {
            _051_FindPathSum target = new _051_FindPathSum(); // TODO: Initialize to an appropriate value
            TreeNode root = new TreeNode(5);
            root.LeftChild = new TreeNode(4);
            root.LeftChild.LeftChild = new TreeNode(11);
            root.LeftChild.LeftChild.LeftChild = new TreeNode(7);
            root.LeftChild.LeftChild.RightChild = new TreeNode(2);
            root.RightChild = new TreeNode(8);
            root.RightChild.LeftChild = new TreeNode(13);
            root.RightChild.RightChild = new TreeNode(4);
            root.RightChild.RightChild.RightChild = new TreeNode(1);

            int value = 22; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.FindPathSum(root, value);
            Assert.AreEqual(expected, actual);


            value = 23; // TODO: Initialize to an appropriate value
            expected = false; // TODO: Initialize to an appropriate value
            actual = target.FindPathSum(root, value);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for FindPathSumII
        ///</summary>
        [TestMethod()]
        public void FindPathSumIITest()
        {
            _051_FindPathSum target = new _051_FindPathSum(); // TODO: Initialize to an appropriate value
            TreeNode root = new TreeNode(5);
            root.LeftChild = new TreeNode(4);
            root.LeftChild.LeftChild = new TreeNode(11);
            root.LeftChild.LeftChild.LeftChild = new TreeNode(7);
            root.LeftChild.LeftChild.RightChild = new TreeNode(2);
            root.RightChild = new TreeNode(8);
            root.RightChild.LeftChild = new TreeNode(13);
            root.RightChild.RightChild = new TreeNode(4);
            root.RightChild.RightChild.LeftChild = new TreeNode(5);
            root.RightChild.RightChild.RightChild = new TreeNode(1);

            int value = 22; // TODO: Initialize to an appropriate value
            
            List<List<int>> actual;
            actual = target.FindPathSumII(root, value);
            Assert.AreEqual(2, actual.Count);
        }
    }
}
