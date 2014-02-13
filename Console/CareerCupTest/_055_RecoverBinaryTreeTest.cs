using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _055_RecoverBinaryTreeTest and is intended
    ///to contain all _055_RecoverBinaryTreeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _055_RecoverBinaryTreeTest
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
        ///A test for RecoverBinaryTree
        ///</summary>
        [TestMethod()]
        public void RecoverBinaryTreeTest()
        {
            _055_RecoverBinaryTree target = new _055_RecoverBinaryTree();
            TreeNode root = new TreeNode(5);
            root.LeftChild = new TreeNode(2);
            root.LeftChild.LeftChild = new TreeNode(6);
            root.LeftChild.LeftChild.RightChild = new TreeNode(1);
            root.LeftChild.RightChild = new TreeNode(3);
            root.LeftChild.RightChild.RightChild = new TreeNode(4);
            root.RightChild = new TreeNode(8);
            root.RightChild.LeftChild = new TreeNode(0);
            root.RightChild.LeftChild.RightChild = new TreeNode(7);
            root.RightChild.RightChild = new TreeNode(10);

            target.RecoverBinaryTree(root);
            Assert.AreEqual(0, root.LeftChild.LeftChild.Value);
            Assert.AreEqual(6, root.RightChild.LeftChild.Value);


            root = new TreeNode(8);
            root.LeftChild = new TreeNode(2);
            root.LeftChild.LeftChild = new TreeNode(0);
            root.LeftChild.LeftChild.RightChild = new TreeNode(1);
            root.LeftChild.RightChild = new TreeNode(3);
            root.LeftChild.RightChild.RightChild = new TreeNode(4);
            root.RightChild = new TreeNode(5);
            root.RightChild.LeftChild = new TreeNode(6);
            root.RightChild.LeftChild.RightChild = new TreeNode(7);
            root.RightChild.RightChild = new TreeNode(10);

            target.RecoverBinaryTree(root);
        }
    }
}
