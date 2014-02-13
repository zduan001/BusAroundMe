using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _044_MaxPathInBTTest and is intended
    ///to contain all _044_MaxPathInBTTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _044_MaxPathInBTTest
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
        ///A test for GetMaxPathSumInBinaryTree
        ///</summary>
        [TestMethod()]
        public void GetMaxPathSumInBinaryTreeTest()
        {
            _044_MaxPathInBT target = new _044_MaxPathInBT();
            //5,4,8,11,#,13,4,7,2,#,#,#,1
            //1,2,#,3,#,4,#,5
            TreeNode root = new TreeNode(5);
            root.LeftChild = new TreeNode(4);
            root.RightChild = new TreeNode(8);
            root.LeftChild.LeftChild = new TreeNode(11);
            root.LeftChild.LeftChild.LeftChild = new TreeNode(7);
            root.LeftChild.LeftChild.RightChild = new TreeNode(2);
            root.RightChild.LeftChild = new TreeNode(13);
            root.RightChild.RightChild = new TreeNode(4);
            root.RightChild.RightChild.LeftChild = new TreeNode(1);


            
            int expected = 48; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetMaxPathSumInBinaryTree(root);
            Assert.AreEqual(expected, actual);
        }
    }
}
