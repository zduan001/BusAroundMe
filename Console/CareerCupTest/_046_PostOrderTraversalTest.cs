using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _046_PostOrderTraversalTest and is intended
    ///to contain all _046_PostOrderTraversalTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _046_PostOrderTraversalTest
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
        ///A test for PostOrderTraversal
        ///</summary>
        [TestMethod()]
        public void PostOrderTraversalTest()
        {
            _046_PostOrderTraversal target = new _046_PostOrderTraversal(); // TODO: Initialize to an appropriate value
            string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            target.PostOrderTraversal(root);
            string expected = "50,10,45,35,20,30,";
            Assert.AreEqual(expected, target.sb.ToString());
        }

        /// <summary>
        ///A test for PostOrderTraversal
        ///</summary>
        [TestMethod()]
        public void PostOrderTraversalIITest()
        {
            _046_PostOrderTraversal target = new _046_PostOrderTraversal(); // TODO: Initialize to an appropriate value
            string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            target.PostOrderTraversalII(root);
            string expected = "50,10,45,35,20,30,";
            Assert.AreEqual(expected, target.sb.ToString());
        }

        /// <summary>
        ///A test for PostOrderTraversal
        ///</summary>
        [TestMethod()]
        public void InorderNextTest()
        {
            _046_FindNextWithParent target = new _046_FindNextWithParent(); // TODO: Initialize to an appropriate value
            string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            root.LeftChild.Parent = root;
            root.LeftChild.LeftChild.Parent = root.LeftChild;
            root.RightChild.Parent = root;
            root.RightChild.LeftChild.Parent = root.RightChild;
            root.RightChild.RightChild.Parent = root.RightChild;
            TreeNode actual = target.FindNode(root.LeftChild);
            Assert.AreEqual(root, actual);

            actual = target.FindNode(root.RightChild.RightChild);
            Assert.AreEqual(null, actual);

        }
    }
}
