using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace ConsoleTestProj
{


    /// <summary>
    ///This is a test class for _035_BinaryTreeMaximumSumPathTest and is intended
    ///to contain all _035_BinaryTreeMaximumSumPathTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _035_BinaryTreeMaximumSumPathTest
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
        ///A test for FindMaxSumPath
        ///</summary>
        [TestMethod()]
        public void FindMaxSumPathTest()
        {
            _035_BinaryTreeMaximumSumPath target = new _035_BinaryTreeMaximumSumPath(); // TODO: Initialize to an appropriate value
            TreeNode root = TreeNode.CreatTree(new string[] {"1", "#", "5", "#", "-7", "#", "#"}); 
            int expected = 6; 
            int actual;
            actual = target.FindMaxSumPath(root);
            Assert.AreEqual(expected, actual);

            TreeNode.index = 0;
            root = TreeNode.CreatTree(new string[] { "1", "100","200","#","#", "200","#", "#", "5", "#", "-7", "#", "#" });
            expected = 500;
            actual = target.FindMaxSumPath(root);
            Assert.AreEqual(expected, actual);

            TreeNode.index = 0;
            root = TreeNode.CreatTree(new string[] { "4", "5", "-7","#", "#",  "#", "6", "#", "#" });
            expected = 15;
            actual = target.FindMaxSumPath(root);
            Assert.AreEqual(expected, actual);


        }
    }
}
