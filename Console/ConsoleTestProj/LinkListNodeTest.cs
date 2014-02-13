using Infra;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for LinkListNodeTest and is intended
    ///to contain all LinkListNodeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LinkListNodeTest
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
        ///A test for ReverseLinkListIterative
        ///</summary>
        [TestMethod()]
        public void ReverseLinkListIterativeTest()
        {
            int[] inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            LinkListNode head = LinkListNode.CreateLinkList(inputArray);
            LinkListNode actual;
            actual = LinkListNode.ReverseLinkListIterative(head);
            for (int i = 6; i >= 0; i--)
            {
                Assert.AreEqual(inputArray[i], actual.Value);
                actual = actual.Next;
            }

            head = new LinkListNode(); head.Value = 1;
            actual = LinkListNode.ReverseLinkListIterative(head);
            Assert.IsNull(actual.Next, "should be only 1 element and next of the first node should be null");
            Assert.AreEqual(1, actual.Value, "value should be 1");

            head = null;
            actual = LinkListNode.ReverseLinkListIterative(head); 
            Assert.IsNull(actual, "should be only 0 element, the first node should be null");
           
        }

        /// <summary>
        ///A test for RevertLinkListRecursive
        ///</summary>
        [TestMethod()]
        public void RevertLinkListRecursiveTest()
        {
            int[] inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            LinkListNode head = LinkListNode.CreateLinkList(inputArray);
            LinkListNode actual;
            actual = LinkListNode.RevertLinkListRecursive(head);
            for (int i = 6; i >= 0; i--)
            {
                Assert.AreEqual(inputArray[i], actual.Value);
                actual = actual.Next;
            }

            head = new LinkListNode(); head.Value = 1;
            actual = LinkListNode.RevertLinkListRecursive(head);
            Assert.IsNull(actual.Next, "should be only 1 element and next of the first node should be null");
            Assert.AreEqual(1, actual.Value, "value should be 1");

            head = null;
            actual = LinkListNode.RevertLinkListRecursive(head);
            Assert.IsNull(actual, "should be only 0 element, the first node should be null");
        }
    }
}
