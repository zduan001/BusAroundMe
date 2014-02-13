using Console2.G_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for G_21_Print2BSTTest and is intended
    ///to contain all G_21_Print2BSTTest Unit Tests
    ///</summary>
    [TestClass()]
    public class G_21_Print2BSTTest
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
        ///A test for Print2BST
        ///</summary>
        [TestMethod()]
        public void Print2BSTTest()
        {
            G_021_Print2BST target = new G_021_Print2BST(); // TODO: Initialize to an appropriate value
            TreeNode root1 = new TreeNode(9);
            root1.LeftChild = new TreeNode(5);
            root1.LeftChild.LeftChild = new TreeNode(1);
            root1.LeftChild.LeftChild.RightChild = new TreeNode(3);
            root1.LeftChild.RightChild = new TreeNode(7);
            root1.RightChild = new TreeNode(15);
            root1.RightChild.LeftChild = new TreeNode(11);


            TreeNode root2 = new TreeNode(10);
            root2.LeftChild = new TreeNode(6);
            root2.LeftChild.LeftChild = new TreeNode(2);
            root2.LeftChild.LeftChild.RightChild = new TreeNode(4);
            root2.LeftChild.RightChild = new TreeNode(8);
            root2.RightChild = new TreeNode(16);
            root2.RightChild.LeftChild = new TreeNode(12);

            List<int> actual;
            actual = target.Print2BST(root1, root2);
            Assert.AreEqual(14, actual.Count);
            for (int i = 1; i < actual.Count; i++)
            {
                Assert.IsTrue(actual[i - 1] <= actual[i]);
            }
        }
    }
}
