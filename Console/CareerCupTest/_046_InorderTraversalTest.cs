using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _046_InorderTraversalTest and is intended
    ///to contain all _046_InorderTraversalTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _046_InorderTraversalTest
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
        ///A test for InOrderTraversal
        ///</summary>
        [TestMethod()]
        public void InOrderTraversalTest()
        {
            _046_InorderTraversal target = new _046_InorderTraversal(); // TODO: Initialize to an appropriate value
            string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode root;
            root = TreeNode.DeserializeTree(inputstring, t);
            target.InOrderTraversal(root);
            string expected = "50,10,30,45,20,35,";
            Assert.AreEqual(expected, target.sb.ToString());
        }
    }
}
