using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _048_MinDepthOfBinaryTreeTest and is intended
    ///to contain all _048_MinDepthOfBinaryTreeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _048_MinDepthOfBinaryTreeTest
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
        ///A test for MinDepth
        ///</summary>
        [TestMethod()]
        public void MinDepthTest()
        {
            _048_MinDepthOfBinaryTree target = new _048_MinDepthOfBinaryTree(); // TODO: Initialize to an appropriate value
            string inputstring = "30,10,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.MinDepth(root);
            Assert.AreEqual(expected, actual);

            root = new TreeNode(1);
            root.LeftChild = new TreeNode(1);
            root.LeftChild.LeftChild = new TreeNode(1);
            root.RightChild = new TreeNode(1);
            root.RightChild.LeftChild = new TreeNode(1);
            root.RightChild.RightChild = new TreeNode(1);
            expected = 3; // TODO: Initialize to an appropriate value
            actual = target.MinDepth(root);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for MaxDepth
        ///</summary>
        [TestMethod()]
        public void MaxDepthTest()
        {
            _048_MinDepthOfBinaryTree target = new _048_MinDepthOfBinaryTree(); // TODO: Initialize to an appropriate value
            TreeNode root = null; // TODO: Initialize to an appropriate value
            root = new TreeNode(1);
            root.LeftChild = new TreeNode(1);
            root.LeftChild.LeftChild = new TreeNode(1);
            root.RightChild = new TreeNode(1);
            root.RightChild.LeftChild = new TreeNode(1);
            root.RightChild.RightChild = new TreeNode(1);
            root.RightChild.RightChild.RightChild = new TreeNode(1);
            int expected = 4; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.MaxDepth(root);
            Assert.AreEqual(expected, actual);
        }
    }
}
