using Infra;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{


    /// <summary>
    ///This is a test class for TreeNodeTest and is intended
    ///to contain all TreeNodeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TreeNodeTest
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
        ///A test for DeserializeTree
        ///</summary>
        [TestMethod()]
        public void DeserializeTreeTest()
        {
            string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode actual;
            actual = TreeNode.DeserializeTree(inputstring, t);
            Assert.AreEqual(30, actual.Value, "root should be 30");
            Assert.AreEqual(10, actual.LeftChild.Value, "left child hsould be 10");
            Assert.AreEqual(50, actual.LeftChild.LeftChild.Value, "left child left child should be 10");
            Assert.IsNull(actual.LeftChild.RightChild, "left child right child should be null");
            Assert.AreEqual(20, actual.RightChild.Value, "root right child should be 2");
            Assert.AreEqual(45, actual.RightChild.LeftChild.Value, "root right child, left child should be 3");
            Assert.AreEqual(35, actual.RightChild.RightChild.Value, "root right child, right child should be 4");


        }

        /// <summary>
        ///A test for SeriallizeTree
        ///</summary>
        [TestMethod()]
        public void SeriallizeTreeTest()
        {
            string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode node = TreeNode.DeserializeTree(inputstring, t);
            string actual = TreeNode.SeriallizeTree(node);
            Assert.AreEqual(inputstring, actual, "After serialize and deserialize the string should be same.");
        }

        /// <summary>
        ///A test for TreeTravelInorder
        ///</summary>
        [TestMethod()]
        public void TreeTravelInorderTest()
        {
            string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode root;
            root = TreeNode.DeserializeTree(inputstring, t);

            string s1 = TreeNode.TreeTravelInorder(root);
            Assert.AreEqual("50,10,30,45,20,35", s1);


            inputstring = "1,#,2,3";
            root = TreeNode.DeserializeTree(inputstring, t);
            s1 = TreeNode.TreeTravelInorder(root);
            Assert.AreEqual("1,3,2", s1);

        }

        /// <summary>
        ///A test for BinaryTreeInorderTravel2
        ///</summary>
        [TestMethod()]
        public void BinaryTreeInorderTravel2Test()
        {
            string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode root;

            root = TreeNode.DeserializeTree(inputstring, t);
            string s1 = TreeNode.BinaryTreeInorderTravel2(root);
            Assert.AreEqual("50,10,30,45,20,35", s1);


            inputstring = "1,#,2,3";
            root = TreeNode.DeserializeTree(inputstring, t);
            s1 = TreeNode.BinaryTreeInorderTravel2(root);
            Assert.AreEqual("1,3,2", s1);
        }

        /// <summary>
        ///A test for TreeTravelPostOrder
        ///</summary>
        [TestMethod()]
        public void TreeTravelPostOrderTest()
        {
            string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode root;
            root = TreeNode.DeserializeTree(inputstring, t);
            string expected = "50,10,45,35,20,30";
            string actual;
            actual = TreeNode.TreeTravelPostOrder(root);
            Assert.AreEqual(expected, actual);



            inputstring = "30,#,#";
            t = ',';
            root = TreeNode.DeserializeTree(inputstring, t);
            expected = "30";
            actual = TreeNode.TreeTravelPostOrder(root);
            Assert.AreEqual(expected, actual);


        }

        /// <summary>
        ///A test for IsASubTree
        ///</summary>
        [TestMethod()]
        public void IsASubTreeTest()
        {

            string inputstring = "20,20,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);

            TreeNode.index = 0;
            string subtreeString = "20,45,#,#,35,#,#";
            TreeNode subRoot = TreeNode.DeserializeTree(subtreeString, t);

            TreeNode t1 = root; 
            TreeNode t2 = subRoot; 
            bool expected = true; 
            bool actual;
            actual = TreeNode.IsASubTree(t1, t2);
            Assert.AreEqual(expected, actual);


            t2 = t1.RightChild;
            expected = true;
            actual = TreeNode.IsASubTree(t1, t2);
            Assert.AreEqual(expected, actual);


            actual = TreeNode.IsASubTreeRef(t1, t2);
            Assert.AreEqual(expected, actual);


        }

        /// <summary>
        ///A test for VerifyBST
        ///</summary>
        [TestMethod()]
        public void VerifyBSTTest()
        {
            string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = TreeNode.VerifyBST(root, int.MinValue, int.MaxValue);
            Assert.AreEqual(expected, actual);

            inputstring = "30,20,10,#,#,#,45,35,#,#,50,#,#";
            root = TreeNode.DeserializeTree(inputstring, t);
            expected = true; // TODO: Initialize to an appropriate value
            actual = TreeNode.VerifyBST(root, int.MinValue, int.MaxValue);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for PrintOutBorder
        ///</summary>
        [TestMethod()]
        public void PrintOutBorderTest()
        {
            string inputstring = "30,10,50,#,#,#,20,45,40,#,#,#,35,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            string s = TreeNode.PrintOutBorder(root);
            Assert.AreEqual("30, 10, 50, 40, 35, 20, 30, ", s);
        }

        /// <summary>
        ///A test for ContructTreeFromPreaAndIn
        ///</summary>
        [TestMethod()]
        public void ContructTreeFromPreaAndInTest()
        {
            int[] preOrder = new int[] { 30, 10, 50, 20, 45, 35 };
            int[] inOrder = new int[] { 50, 10, 30, 45, 20, 35 };
            TreeNode actual = TreeNode.ContructTreeFromPreaAndIn(preOrder, inOrder);
            Assert.AreEqual(30, actual.Value, "root");
            Assert.AreEqual(10, actual.LeftChild.Value, "root->left");
            Assert.AreEqual(50, actual.LeftChild.LeftChild.Value, "root->left->left");
            Assert.AreEqual(20, actual.RightChild.Value, "root->right");
            Assert.AreEqual(45, actual.RightChild.LeftChild.Value, "root->right->left");
            Assert.AreEqual(35, actual.RightChild.RightChild.Value, "root->right->right");
            
        }
    }
}
