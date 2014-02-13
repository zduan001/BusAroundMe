using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _058_RemoveDupFromSortedListTest and is intended
    ///to contain all _058_RemoveDupFromSortedListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _058_RemoveDupFromSortedListTest
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
            _058_RemoveDupFromSortedList target = new _058_RemoveDupFromSortedList(); // TODO: Initialize to an appropriate value
            LinkListNode head = LinkListNode.CreateLinkList(new int[] { 1,1,1,2,2,2,3,3});
            LinkListNode expected = LinkListNode.CreateLinkList(new int[] { 1, 2, 3 });
            LinkListNode actual;
            actual = target.RemoveDup(head);
            Assert.AreEqual(expected.Value, actual.Value);
            expected = expected.Next;
            actual = actual.Next;
            Assert.AreEqual(expected.Value, actual.Value);
            expected = expected.Next;
            actual = actual.Next;
            Assert.AreEqual(expected.Value, actual.Value);
        }

        /// <summary>
        ///A test for RemoveDupII
        ///</summary>
        [TestMethod()]
        public void RemoveDupIITest()
        {
            _058_RemoveDupFromSortedList target = new _058_RemoveDupFromSortedList(); // TODO: Initialize to an appropriate value
            LinkListNode head = LinkListNode.CreateLinkList(new int[] {1,2,3,3,4,4,5});
            LinkListNode expected = LinkListNode.CreateLinkList(new int[] { 1, 2, 5 });
            LinkListNode actual;
            actual = target.RemoveDupII(head);
            Assert.AreEqual(expected.Value, actual.Value);
            expected = expected.Next;
            actual = actual.Next;
            Assert.AreEqual(expected.Value, actual.Value);
            expected = expected.Next;
            actual = actual.Next;
            Assert.AreEqual(expected.Value, actual.Value);
        }

        /// <summary>
        ///A test for RemoveDup
        ///</summary>
        [TestMethod()]
        public void RemoveDupTest1()
        {
            //_058_RemoveDupFromSortedList target = new _058_RemoveDupFromSortedList();
            //int[] input = new int[] { 1, 2, 3, 4 };
            //int value = 4;
            //int expected = 3;
            //int actual;
            //actual = target.RemoveDup(input, value);
            //Assert.AreEqual(expected, actual);

            ////1,2,3,4
            //value = 5;
            //expected = 4;
            //actual = target.RemoveDup(input, value);
            //Assert.AreEqual(expected, actual);
            

        }
    }
}
