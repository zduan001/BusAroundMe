using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _054_SameTreeTest and is intended
    ///to contain all _054_SameTreeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _054_SameTreeTest
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
        ///A test for VerifySameTree
        ///</summary>
        [TestMethod()]
        public void VerifySameTreeTest()
        {
            _054_SameTree target = new _054_SameTree(); // TODO: Initialize to an appropriate value
            string inputstring1 = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            string inputstring2 = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            TreeNode t1 = TreeNode.DeserializeTree(inputstring1,',');
            TreeNode t2 = TreeNode.DeserializeTree(inputstring2, ',');
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.VerifySameTree(t1, t2);
            Assert.AreEqual(expected, actual);


            inputstring1 = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            inputstring2 = "30,10,50,#,#,#,20,45,#,#,45,#,#";
            t1 = TreeNode.DeserializeTree(inputstring1, ',');
            t2 = TreeNode.DeserializeTree(inputstring2, ',');
            expected = false;
            actual = target.VerifySameTree(t1, t2);
            Assert.AreEqual(expected, actual);

            inputstring1 = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            inputstring2 = "30,10,50,#,#,#,20,45,#,#,45,30,#,#,#";
            t1 = TreeNode.DeserializeTree(inputstring1, ',');
            t2 = TreeNode.DeserializeTree(inputstring2, ',');
            expected = false;
            actual = target.VerifySameTree(t1, t2);
            Assert.AreEqual(expected, actual);
        }
    }
}
