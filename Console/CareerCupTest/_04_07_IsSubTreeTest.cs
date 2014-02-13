using CareerCup150.Chapter4_TreeGraph;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _04_07_IsSubTreeTest and is intended
    ///to contain all _04_07_IsSubTreeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _04_07_IsSubTreeTest
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
        ///A test for IsASubTree
        ///</summary>
        [TestMethod()]
        public void IsASubTreeTest()
        {
            _04_07_IsSubTree target = new _04_07_IsSubTree(); // TODO: Initialize to an appropriate value

            string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode root;
            root = TreeNode.DeserializeTree(inputstring, t);

            TreeNode t1 = root.RightChild;
            bool expected = true;
            bool actual = target.IsASubTree(root, t1);
            Assert.AreEqual(expected, actual);

            t1 = new TreeNode(100);
            expected = false;
            actual = target.IsASubTree(root, t1);
            Assert.AreEqual(expected, actual);
        }
    }
}
