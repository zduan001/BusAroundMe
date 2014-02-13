using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _032_CaculateTreeTest and is intended
    ///to contain all _032_CaculateTreeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _032_CaculateTreeTest
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
        ///A test for CalcuateTree
        ///</summary>
        [TestMethod()]
        public void CalcuateTreeTest()
        {
            _032_CaculateTree target = new _032_CaculateTree(); // TODO: Initialize to an appropriate value

            StrTreeNode root = new StrTreeNode("+");
            root.leftChild = new StrTreeNode("*");
            root.leftChild.leftChild = new StrTreeNode("5");
            root.leftChild.rightChild = new StrTreeNode("10");
            root.rightChild = new StrTreeNode("/");
            root.rightChild.leftChild = new StrTreeNode("5");
            root.rightChild.rightChild = new StrTreeNode("10");

            double expected = 50.5;
            double actual;
            actual = target.CalcuateTree(root);
            Assert.AreEqual(expected, actual);

            root = new StrTreeNode("/");
            root.leftChild = new StrTreeNode("*");
            root.leftChild.leftChild = new StrTreeNode("5");
            root.leftChild.rightChild = new StrTreeNode("-");
            root.leftChild.rightChild.leftChild = new StrTreeNode("9");
            root.leftChild.rightChild.rightChild = new StrTreeNode("1");
            root.rightChild = new StrTreeNode("/");
            root.rightChild.leftChild = new StrTreeNode("5");
            root.rightChild.rightChild = new StrTreeNode("10");

            expected = 80;
            actual = target.CalcuateTree(root);
            Assert.AreEqual(expected, actual);
        }
    }
}
