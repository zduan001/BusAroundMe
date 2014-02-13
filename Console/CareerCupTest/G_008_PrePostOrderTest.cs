using Console2.G_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for G_008_PrePostOrderTest and is intended
    ///to contain all G_008_PrePostOrderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class G_008_PrePostOrderTest
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
        ///A test for ConstructTree
        ///</summary>
        [TestMethod()]
        public void ConstructTreeTest()
        {
            G_008_PrePostOrder target = new G_008_PrePostOrder(); // TODO: Initialize to an appropriate value
            int[] preorder = new int[] { 4, 1, 2, 3, 6, 5 };
            int preStart = 0; 
            int preEnd = 5;
            int[] inorder = new int[] { 1, 2, 3, 4, 5, 6 };
            int inStart = 0; 
            int inEnd = 5; 
            TreeNode actual;
            actual = target.ConstructTree(preorder, preStart, preEnd, inorder, inStart, inEnd);
            string str = TreeNode.SeriallizeTree(actual);
        }
    }
}
