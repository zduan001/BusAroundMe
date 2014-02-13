using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace ConsoleTestProj
{


    /// <summary>
    ///This is a test class for _008_ConverToBinaryTreeTest and is intended
    ///to contain all _008_ConverToBinaryTreeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _008_ConverToBinaryTreeTest
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
        ///A test for ConvertSortArraytoBalancedBST
        ///</summary>
        [TestMethod()]
        public void ConvertSortArraytoBalancedBSTTest()
        {
            _008_ConverToBinaryTree target = new _008_ConverToBinaryTree(); 
            TreeNode actual;
            int[] input;

            input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // TODO: Initialize to an appropriate value
            actual = target.ConvertSortArraytoBalancedBST(input);
            Assert.IsTrue(TreeNode.VerifyIfATreeIsABST(actual), "array 1 is not BST");
            Assert.IsTrue(TreeNode.VerifyIfBalanced(actual), "array 1 is not balanced");

            input = new int[] { 1, 2, 3 }; // TODO: Initialize to an appropriate value
            actual = target.ConvertSortArraytoBalancedBST(input);
            Assert.IsTrue(TreeNode.VerifyIfATreeIsABST(actual), "array 2 is not BST");
            Assert.IsTrue(TreeNode.VerifyIfBalanced(actual), "array 2 is not balanced");

            input = new int[] { 3, 2, 1, 9, 4, 2, 100, 3, 6, 0 }; // TODO: Initialize to an appropriate value
            actual = target.ConvertSortArraytoBalancedBST(input);
            Assert.IsFalse(TreeNode.VerifyIfATreeIsABST(actual), "array 3 is BST, but should not be");
            Assert.IsTrue(TreeNode.VerifyIfBalanced(actual), "array 3 is not balanced");

        }

        /// <summary>
        ///A test for ConvertSortedLinkListtoBalancedBST
        ///</summary>
        [TestMethod()]
        public void ConvertSortedLinkListtoBalancedBSTTest()
        {
            _008_ConverToBinaryTree target = new _008_ConverToBinaryTree(); // TODO: Initialize to an appropriate value
            LinkListNode input = LinkListNode.CreateLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            TreeNode actual;
            actual = target.ConvertSortedLinkListtoBalancedBST(input);
            Assert.IsTrue(TreeNode.VerifyIfATreeIsABST(actual), "array 1 is not BST");
            Assert.IsTrue(TreeNode.VerifyIfBalanced(actual), "array 1 is not balanced");

            TreeNode actualArrayInput;
            int[] inputArrayInput;

            inputArrayInput = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            actualArrayInput = target.ConvertSortArraytoBalancedBST(inputArrayInput);


            string s1 = TreeNode.SeriallizeTree(actual);
            string s2 = TreeNode.SeriallizeTree(actualArrayInput);
            //Assert.AreEqual(s1, s2, "Array or Linklist input result should be same");
            
        }
    }
}
