using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;
using System.Collections.Generic;

namespace CareerCupTest
{


    /// <summary>
    ///This is a test class for _034_MergeKSortedListTest and is intended
    ///to contain all _034_MergeKSortedListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _034_MergeKSortedListTest
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
        ///A test for MergeLinkedList
        ///</summary>
        [TestMethod()]
        public void MergeLinkedListTest()
        {
            _034_MergeKSortedList target = new _034_MergeKSortedList(); // TODO: Initialize to an appropriate value
            LinkListNode list1 = LinkListNode.CreateLinkList(new[] { 1, 3, 6, 8, 9, 12, 34 });
            LinkListNode list2 = LinkListNode.CreateLinkList(new[] { 2, 4, 7, 22 });
            LinkListNode list3 = LinkListNode.CreateLinkList(new[] { 0, 5, 11, 31 });
            LinkListNode list4 = LinkListNode.CreateLinkList(new[] { 10, 13, 20 });
            List<LinkListNode> input = new List<LinkListNode>() { list1, list2, list3, list4 };
            LinkListNode actual;
            actual = target.MergeLinkedList(input);

        }
    }
}
