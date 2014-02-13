using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _065_RotateListTest and is intended
    ///to contain all _065_RotateListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _065_RotateListTest
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
        ///A test for RotateRight
        ///</summary>
        [TestMethod()]
        public void RotateRightTest()
        {
            _065_RotateList target = new _065_RotateList(); // TODO: Initialize to an appropriate value
            LinkListNode head = LinkListNode.CreateLinkList(new int[] {1,2,3,4,5});
            int k = 2; // TODO: Initialize to an appropriate value
            LinkListNode expected = LinkListNode.CreateLinkList(new int[] { 4, 5, 1, 2, 3 });
            LinkListNode actual;
            actual = target.RotateRight(head, k);
            while (expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }


            head = LinkListNode.CreateLinkList(new int[] { 1, 2, 3, 4, 5 });
            k = 5;
            expected = LinkListNode.CreateLinkList(new int[] { 1, 2, 3, 4, 5 });
            actual = target.RotateRight(head, k);
            while (expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }


            head = LinkListNode.CreateLinkList(new int[] { 1, 2, 3, 4, 5 });
            k = 10;
            expected = LinkListNode.CreateLinkList(new int[] { 1, 2, 3, 4, 5 });
            actual = target.RotateRight(head, k);
            while (expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }


            head = LinkListNode.CreateLinkList(new int[] { 1, 2, 3, 4, 5 });
            k = 8;
            expected = LinkListNode.CreateLinkList(new int[] { 3, 4, 5, 1, 2 });
            actual = target.RotateRight(head, k);
            while (expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }
        }
    }
}
