using Console2.From_001_To_025;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _009_TreeTravelRelatedTest and is intended
    ///to contain all _009_TreeTravelRelatedTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _009_TreeTravelRelatedTest
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
        ///A test for InorderTravel
        ///</summary>
        [TestMethod()]
        public void InorderTravelTest()
        {
            _009_TreeTravelRelated target = new _009_TreeTravelRelated(); // TODO: Initialize to an appropriate value

            string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
                        
            string expected = "50,10,30,45,20,35,";
            string actual;
            actual = target.InorderTravel(root);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for PostOrderTravel
        ///</summary>
        [TestMethod()]
        public void PostOrderTravelTest()
        {
            _009_TreeTravelRelated target = new _009_TreeTravelRelated(); // TODO: Initialize to an appropriate value
            string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);

            string expected = "50,10,45,35,20,30,";
            string actual = target.PostOrderTravel(root);
            Assert.AreEqual(expected, actual);
        }
    }
}
