using CareerCup150.Chapt2_LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _02_05_HeadofCircularTest and is intended
    ///to contain all _02_05_HeadofCircularTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _02_05_HeadofCircularTest
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
        ///A test for FindHeadOfCircular
        ///</summary>
        [TestMethod()]
        public void FindHeadOfCircularTest()
        {
            _02_05_HeadofCircular target = new _02_05_HeadofCircular(); // TODO: Initialize to an appropriate value

            int[] inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            LinkListNode head = LinkListNode.CreateLinkList(inputArray);

            LinkListNode tmp = head.Next.Next.Next; // node 4.

            LinkListNode tail = head;
            while (tail.Value != 7) tail = tail.Next;
            tail.Next = tmp;
            
            LinkListNode expected = tmp; 
            LinkListNode actual;
            actual = target.FindHeadOfCircular(head);
            Assert.AreEqual(expected, actual);
        }
    }
}
