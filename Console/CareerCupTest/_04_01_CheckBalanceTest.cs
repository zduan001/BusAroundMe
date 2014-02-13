using CareerCup150.Chapter4_TreeGraph;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _04_01_CheckBalanceTest and is intended
    ///to contain all _04_01_CheckBalanceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _04_01_CheckBalanceTest
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
        ///A test for IsBalanceTree
        ///</summary>
        [TestMethod()]
        public void IsBalanceTreeTest()
        {
            _04_01_CheckBalance target = new _04_01_CheckBalance(); // TODO: Initialize to an appropriate value
            string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsBalanceTree(root);
            Assert.AreEqual(expected, actual);

            inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            root = TreeNode.DeserializeTree(inputstring, t);
            root.LeftChild.LeftChild = new TreeNode(100);
            root.LeftChild.LeftChild.LeftChild = new TreeNode(100);
            root.LeftChild.LeftChild.LeftChild.LeftChild = new TreeNode(100);
            expected = false;
            actual = target.IsBalanceTree(root);
            Assert.AreEqual(expected, actual);
        }
    }
}
