using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _054_PopulateNextRightTest and is intended
    ///to contain all _054_PopulateNextRightTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _054_PopulateNextRightTest
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
        ///A test for NextRight
        ///</summary>
        [TestMethod()]
        public void NextRightTest()
        {
            _054_PopulateNextRight target = new _054_PopulateNextRight(); // TODO: Initialize to an appropriate value
            TreeNodeWithNext root = new TreeNodeWithNext(1);
            root.LeftChild = new TreeNodeWithNext(2);
            root.LeftChild.LeftChild = new TreeNodeWithNext(4);
            root.LeftChild.RightChild = new TreeNodeWithNext(5);
            root.RightChild = new TreeNodeWithNext(3);
            root.RightChild.RightChild = new TreeNodeWithNext(7);

            target.NextRight(root);
            Assert.IsTrue(root.Next == null);
            Assert.AreEqual(3, root.LeftChild.Next.Value);
            Assert.AreEqual(5, root.LeftChild.LeftChild.Next.Value);
            Assert.AreEqual(7, root.LeftChild.LeftChild.Next.Next.Value);
        }
    }
}
