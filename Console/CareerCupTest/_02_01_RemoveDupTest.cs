using CareerCup150.Chapt2_LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _02_01_RemoveDupTest and is intended
    ///to contain all _02_01_RemoveDupTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _02_01_RemoveDupTest
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
        ///A test for RemoveDup
        ///</summary>
        [TestMethod()]
        public void RemoveDupTest()
        {
            _02_01_RemoveDup target = new _02_01_RemoveDup(); // TODO: Initialize to an appropriate value
            int[] inputArray = new int[] { 1, 2, 3, 4, 5, 4, 7 };
            LinkListNode head = LinkListNode.CreateLinkList(inputArray);
            int[] inputArray2 = new int[] { 1, 2, 3, 4, 5, 7 };
            LinkListNode expected = LinkListNode.CreateLinkList(inputArray2);
            LinkListNode actual = target.RemoveDup(head);
            while (actual != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                actual = actual.Next;
                expected = expected.Next;
            }

            inputArray = new int[] { 1, 1, 1, 1, 1, 1, 1 };
            head = LinkListNode.CreateLinkList(inputArray);
            inputArray2 = new int[] { 1 };
            expected = LinkListNode.CreateLinkList(inputArray2);
            actual = target.RemoveDup(head);
            while (actual != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                actual = actual.Next;
                expected = expected.Next;
            }

            inputArray = new int[] { 1, 1, 2, 2, 1, 1, 2 };
            head = LinkListNode.CreateLinkList(inputArray);
            inputArray2 = new int[] { 1,2 };
            expected = LinkListNode.CreateLinkList(inputArray2);
            actual = target.RemoveDup(head);
            while (actual != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                actual = actual.Next;
                expected = expected.Next;
            }
        }

        /// <summary>
        ///A test for RemoveDupNoHashTable
        ///</summary>
        [TestMethod()]
        public void RemoveDupNoHashTableTest()
        {
            _02_01_RemoveDup target = new _02_01_RemoveDup(); // TODO: Initialize to an appropriate value

            int[] inputArray = new int[] { 1, 2, 3, 4, 5, 4, 7 };
            LinkListNode head = LinkListNode.CreateLinkList(inputArray);
            int[] inputArray2 = new int[] { 1, 2, 3, 4, 5, 7 };
            LinkListNode expected = LinkListNode.CreateLinkList(inputArray2);
            LinkListNode actual = target.RemoveDupNoHashTable(head);
            while (actual != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                actual = actual.Next;
                expected = expected.Next;
            }

            inputArray = new int[] { 1, 1, 1, 1, 1, 1, 1 };
            head = LinkListNode.CreateLinkList(inputArray);
            inputArray2 = new int[] { 1 };
            expected = LinkListNode.CreateLinkList(inputArray2);
            actual = target.RemoveDupNoHashTable(head);
            while (actual != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                actual = actual.Next;
                expected = expected.Next;
            }

            inputArray = new int[] { 1, 1, 2, 2, 1, 1, 2 };
            head = LinkListNode.CreateLinkList(inputArray);
            inputArray2 = new int[] { 1, 2 };
            expected = LinkListNode.CreateLinkList(inputArray2);
            actual = target.RemoveDupNoHashTable(head);
            while (actual != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                actual = actual.Next;
                expected = expected.Next;
            }
        }

    }
}
