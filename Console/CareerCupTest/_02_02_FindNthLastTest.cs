using CareerCup150.Chapt2_LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _02_02_FindNthLastTest and is intended
    ///to contain all _02_02_FindNthLastTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _02_02_FindNthLastTest
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
        ///A test for FindNthNode
        ///</summary>
        [TestMethod()]
        public void FindNthNodeTest()
        {
            _02_02_FindNthLast target = new _02_02_FindNthLast(); // TODO: Initialize to an appropriate value
            int[] inputArray = new int[] { 1, 2, 3, 4, 5, 4, 7 };
            LinkListNode head = LinkListNode.CreateLinkList(inputArray);
            int n = 3;
            LinkListNode expected = new LinkListNode();
            expected.Value = 5;
            LinkListNode actual = target.FindNthNode(head, n);
            Assert.AreEqual(expected.Value, actual.Value);

            inputArray = new int[] { 1, 2, 3, 4, 5, 4, 7 };
            head = LinkListNode.CreateLinkList(inputArray);
            n = 100;
            expected = null;
            actual = target.FindNthNode(head, n);
            Assert.IsNull(actual);

            inputArray = new int[] { 1, 2, 3, 4, 5, 4, 7 };
            head = LinkListNode.CreateLinkList(inputArray);
            n = 7;
            expected = new LinkListNode();
            expected.Value = 1;
            actual = target.FindNthNode(head, n);
            Assert.AreEqual(expected.Value, actual.Value);
        }
    }
}
