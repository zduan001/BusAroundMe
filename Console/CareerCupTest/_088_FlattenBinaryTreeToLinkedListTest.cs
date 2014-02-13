using Console2.From_076_To_100;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _088_FlattenBinaryTreeToLinkedListTest and is intended
    ///to contain all _088_FlattenBinaryTreeToLinkedListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _088_FlattenBinaryTreeToLinkedListTest
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
        ///A test for FlattenTree
        ///</summary>
        [TestMethod()]
        public void FlattenTreeTest()
        {
            _088_FlattenBinaryTreeToLinkedList target = new _088_FlattenBinaryTreeToLinkedList(); // TODO: Initialize to an appropriate value
            TreeNode root = new TreeNode(1);
            root.LeftChild = new TreeNode(2);
            root.LeftChild.LeftChild = new TreeNode(3);
            root.LeftChild.RightChild = new TreeNode(4);
            root.RightChild = new TreeNode(5);
            root.RightChild.RightChild = new TreeNode(6);
            target.FlattenTree(root);
            Assert.AreEqual(1, root.Value);
            root = root.RightChild;
            Assert.AreEqual(5, root.Value);
            root = root.RightChild;
            Assert.AreEqual(6, root.Value);
            root = root.RightChild;
            Assert.AreEqual(2, root.Value);
            root = root.RightChild;
            Assert.AreEqual(4, root.Value);
            root = root.RightChild;
            Assert.AreEqual(3, root.Value);
        }
    }
}
