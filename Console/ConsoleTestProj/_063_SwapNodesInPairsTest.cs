using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace ConsoleTestProj
{


    /// <summary>
    ///This is a test class for _063_SwapNodesInPairsTest and is intended
    ///to contain all _063_SwapNodesInPairsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _063_SwapNodesInPairsTest
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
        ///A test for SwapNodeInPairs
        ///</summary>
        [TestMethod()]
        public void SwapNodeInPairsTest()
        {
            _063_SwapNodesInPairs target = new _063_SwapNodesInPairs(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] output = new int[] { 2, 1, 4, 3, 6, 5, 8, 7, 0, 9 };
            LinkListNode head = LinkListNode.CreateLinkList(input);
            LinkListNode expected = LinkListNode.CreateLinkList(output);
            LinkListNode actual = target.SwapNodeInPairs(head);
            while (expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }
        }
    }
}
