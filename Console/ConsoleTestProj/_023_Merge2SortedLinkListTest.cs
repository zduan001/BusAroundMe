using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _023_Merge2SortedLinkListTest and is intended
    ///to contain all _023_Merge2SortedLinkListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _023_Merge2SortedLinkListTest
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
        ///A test for Merger
        ///</summary>
        [TestMethod()]
        public void MergerTest()
        {
            _023_Merge2SortedLinkList target = new _023_Merge2SortedLinkList(); // TODO: Initialize to an appropriate value
            LinkListNode l1 = null; // TODO: Initialize to an appropriate value
            LinkListNode l2 = null; // TODO: Initialize to an appropriate value
            LinkListNode expected = null; // TODO: Initialize to an appropriate value
            LinkListNode actual;
            actual = target.Merger(l1, l2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MergerKSortedList
        ///</summary>
        [TestMethod()]
        public void MergerKSortedListTest()
        {
            _023_Merge2SortedLinkList target = new _023_Merge2SortedLinkList();
            LinkListNode node1 = LinkListNode.CreateLinkList(new int[] { 1, 4});
            LinkListNode node2 = LinkListNode.CreateLinkList(new int[] { 2, 3 });
            LinkListNode node3 = LinkListNode.CreateLinkList(new int[] { 1, 5});

            List<LinkListNode> input = new List<LinkListNode>() { node1, node2, node3 }; 
            LinkListNode actual;
            actual = target.MergerKSortedList(input);

            LinkListNode expected = LinkListNode.CreateLinkList(new int[] { 1, 1, 2, 3, 4, 5});

            for (int i = 0; i < 6; i++)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }


            node1 = LinkListNode.CreateLinkList(new int[] { 1, 4, 6, 9, 18, 34, 100 });
            node2 = LinkListNode.CreateLinkList(new int[] { 2, 3, 16 });
            node3 = LinkListNode.CreateLinkList(new int[] { 1, 5, 6, 7, 16, 17, 36, 77 });

            input = new List<LinkListNode>() { node1, node2, node3 };
            actual = target.MergerKSortedList(input);

            expected = LinkListNode.CreateLinkList(new int[] { 1, 1, 2, 3, 4, 5, 6, 6, 7, 9, 16, 16, 17, 18, 34, 36, 77, 100 });

            for (int i = 0; i < 15; i++)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }
        }
    }
}
