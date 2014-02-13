using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeCSharp;
using Infra;

namespace LeetCodeCsharpTest
{
    /// <summary>
    /// Summary description for Test_004SumToLeafNumbers
    /// </summary>
    [TestClass]
    public class Test_004SumToLeafNumbers
    {
        public Test_004SumToLeafNumbers()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Test_004SumtoLeafNumbers()
        {
            _004_SumRoottoLeafNumbers target = new _004_SumRoottoLeafNumbers();
            //string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            string inputstring = "1,2,#,#,3,#,#";
            char t = ',';
            TreeNode node = TreeNode.DeserializeTree(inputstring, t);
            int actual = target.CalCulateSum(node);
            Assert.AreEqual(25, actual);
        }
    }
}
