using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _061_ReverseLinkedListTest and is intended
    ///to contain all _061_ReverseLinkedListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _061_ReverseLinkedListTest
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
        ///A test for ReverseLinkedListII
        ///</summary>
        [TestMethod()]
        public void ReverseLinkedListIITest()
        {
            _061_ReverseLinkedList target = new _061_ReverseLinkedList(); // TODO: Initialize to an appropriate value
            LinkListNode head = LinkListNode.CreateLinkList(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9});
            int m = 2;
            int n = 4;
            LinkListNode expected = LinkListNode.CreateLinkList(new int[] { 1, 4, 3, 2, 5, 6, 7, 8, 9 });
            LinkListNode actual;
            actual = target.ReverseLinkedListII(head, m, n);
            while (expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }
        }
    }
}
