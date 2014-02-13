using CareerCup150.Chapt2_LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _02_03_DeleteMidNodeTest and is intended
    ///to contain all _02_03_DeleteMidNodeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _02_03_DeleteMidNodeTest
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
        ///A test for DeleteMiddleNode
        ///</summary>
        [TestMethod()]
        public void DeleteMiddleNodeTest()
        {
            _02_03_DeleteMidNode target = new _02_03_DeleteMidNode(); // TODO: Initialize to an appropriate value

            int[] inputArray = new int[] { 1, 2, 3, 4, 5, 4, 7 };
            LinkListNode head = LinkListNode.CreateLinkList(inputArray);

            int[] inputArray2 = new int[] { 1, 2, 3, 5, 4, 7 };
            LinkListNode expected = LinkListNode.CreateLinkList(inputArray2);

            LinkListNode node = head;
            for (int i = 0; i < 3; i++)
            {
                node = node.Next;
            }
            target.DeleteMiddleNode(node);

            for (int i = 0; i < 6; i++)
            {
                Assert.AreEqual(expected.Value, head.Value);
                expected = expected.Next;
                head = head.Next;
            }

            // check for corner cases.
            head = LinkListNode.CreateLinkList(inputArray);
            node = head;
            while (node.Next != null)
            {
                node = node.Next;
            }
            Assert.AreEqual(false, target.DeleteMiddleNode(null));
            Assert.AreEqual(false, target.DeleteMiddleNode(node));
        }
    }
}
