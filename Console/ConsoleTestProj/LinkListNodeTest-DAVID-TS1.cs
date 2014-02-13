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

        /// <summary>
        ///A test for RemoveDupsAll
        ///</summary>
        [TestMethod()]
        public void RemoveDupsAllTest()
        {
            int[] inputArray = new int[] { 1, 2, 3, 3, 3, 6, 7 };
            LinkListNode input = LinkListNode.CreateLinkList(inputArray);
            LinkListNode actual;
            actual = LinkListNode.RemoveDupsAll(input);

            Assert.AreEqual(1, actual.Value);
            Assert.AreEqual(2, actual.Next.Value);
            Assert.AreEqual(6, actual.Next.Next.Value);
            Assert.AreEqual(7, actual.Next.Next.Next.Value);
            Assert.IsNull(actual.Next.Next.Next.Next);

            inputArray = new int[] { 1, 2, 4, 3, 3, 3 };
            input = LinkListNode.CreateLinkList(inputArray);
            actual = LinkListNode.RemoveDupsAll(input);
            Assert.AreEqual(1, actual.Value);
            Assert.AreEqual(2, actual.Next.Value);
            Assert.AreEqual(4, actual.Next.Next.Value);
            Assert.IsNull(actual.Next.Next.Next);

            inputArray = new int[] { 3, 3 };
            input = LinkListNode.CreateLinkList(inputArray);
            actual = LinkListNode.RemoveDupsAll(input);
            Assert.IsNull(actual);

            inputArray = new int[] { 3};
            input = LinkListNode.CreateLinkList(inputArray);
            actual = LinkListNode.RemoveDupsAll(input);
            Assert.AreEqual(3, actual.Value);
            Assert.IsNull(actual.Next);

            inputArray = new int[] { 3,2 };
            input = LinkListNode.CreateLinkList(inputArray);
            actual = LinkListNode.RemoveDupsAll(input);
            Assert.AreEqual(3, actual.Value);
            Assert.AreEqual(2, actual.Next.Value);
            Assert.IsNull(actual.Next.Next);

            inputArray = new int[] { 3, 3, 4 };
            input = LinkListNode.CreateLinkList(inputArray);
            actual = LinkListNode.RemoveDupsAll(input);
            Assert.AreEqual(4, actual.Value);
            Assert.IsNull(actual.Next);
        }



        /// <summary>
        ///A test for RemoveDups
        ///</summary>
        [TestMethod()]
        public void RemoveDupsTest()
        {
            int[] inputArray = new int[] { 1, 2, 3, 3, 3, 6, 7 };
            LinkListNode input = LinkListNode.CreateLinkList(inputArray);
            LinkListNode actual;
            actual = LinkListNode.RemoveDups(input);

            Assert.AreEqual(1, actual.Value);
            Assert.AreEqual(2, actual.Next.Value);
            Assert.AreEqual(3, actual.Next.Next.Value);
            Assert.AreEqual(6, actual.Next.Next.Next.Value);
            Assert.AreEqual(7, actual.Next.Next.Next.Next.Value);
            Assert.IsNull(actual.Next.Next.Next.Next.Next);

            inputArray = new int[] { 1, 2, 4, 3, 3, 3 };
            input = LinkListNode.CreateLinkList(inputArray);
            actual = LinkListNode.RemoveDups(input);
            Assert.AreEqual(1, actual.Value);
            Assert.AreEqual(2, actual.Next.Value);
            Assert.AreEqual(4, actual.Next.Next.Value);
            Assert.AreEqual(3, actual.Next.Next.Next.Value);
            Assert.IsNull(actual.Next.Next.Next.Next);

            inputArray = new int[] { 3, 3 };
            input = LinkListNode.CreateLinkList(inputArray);
            actual = LinkListNode.RemoveDups(input);
            Assert.AreEqual(3, actual.Value);
            Assert.IsNull(actual.Next);

            inputArray = new int[] { 3};
            input = LinkListNode.CreateLinkList(inputArray);
            actual = LinkListNode.RemoveDupsAll(input);
            Assert.AreEqual(3, actual.Value);
            Assert.IsNull(actual.Next);

            inputArray = new int[] { 3,2 };
            input = LinkListNode.CreateLinkList(inputArray);
            actual = LinkListNode.RemoveDups(input);
            Assert.AreEqual(3, actual.Value);
            Assert.AreEqual(2, actual.Next.Value);
            Assert.IsNull(actual.Next.Next);

            inputArray = new int[] { 3, 3, 4 };
            input = LinkListNode.CreateLinkList(inputArray);
            actual = LinkListNode.RemoveDups(input);
            Assert.AreEqual(3, actual.Value);
            Assert.AreEqual(4, actual.Next.Value);
            Assert.IsNull(actual.Next.Next);
        }



        /// <summary>
        ///A test for RemoveNthNodeFromEnd
        ///</summary>
        [TestMethod()]
        public void RemoveNthNodeFromEndTest()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] output = new int[] { 1, 2, 3, 5, 6 };
            LinkListNode head = LinkListNode.CreateLinkList(input);
            LinkListNode expected = LinkListNode.CreateLinkList(output);
            int n = 3; 
            LinkListNode actual;
            actual = LinkListNode.RemoveNthNodeFromEnd(head, n);

            while (actual != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                actual = actual.Next;
                expected = expected.Next;
            }

            input = new int[] { 1, 2, 3, 4, 5, 6 };
            output = new int[] { 1, 2, 3,4, 5, 6 };
            head = LinkListNode.CreateLinkList(input);
            expected = LinkListNode.CreateLinkList(output);
            n = 100;
            actual = LinkListNode.RemoveNthNodeFromEnd(head, n);

            while (actual != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                actual = actual.Next;
                expected = expected.Next;
            }

            input = new int[] { 1, 2, 3, 4, 5, 6 };
            output = new int[] { 2, 3, 4, 5, 6 };
            head = LinkListNode.CreateLinkList(input);
            expected = LinkListNode.CreateLinkList(output);
            n = 6;
            actual = LinkListNode.RemoveNthNodeFromEnd(head, n);

            while (actual != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                actual = actual.Next;
                expected = expected.Next;
            }

            input = new int[] { 1, 2, 3, 4, 5, 6 };
            output = new int[] { 1, 2, 3, 4, 5, 6 };
            head = LinkListNode.CreateLinkList(input);
            expected = LinkListNode.CreateLinkList(output);
            n = 0;
            actual = LinkListNode.RemoveNthNodeFromEnd(head, n);

            while (actual != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                actual = actual.Next;
                expected = expected.Next;
            }



        }

        /// <summary>
        ///A test for RevertPartialLinkList
        ///</summary>
        [TestMethod()]
        public void RevertPartialLinkListTest()
        {

            int[] inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] outputArray = new int[] { 1, 2, 5, 4, 3, 6, 7 };
            LinkListNode head = LinkListNode.CreateLinkList(inputArray);
            LinkListNode expected = LinkListNode.CreateLinkList(outputArray);
            int start = 3; 
            int end = 5; 
            LinkListNode actual = LinkListNode.RevertPartialLinkList(head,start, end);

            while (actual != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }


            inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            outputArray = new int[] { 7, 6, 5, 4, 3, 2, 1 };
            head = LinkListNode.CreateLinkList(inputArray);
            expected = LinkListNode.CreateLinkList(outputArray);
            start = 1;
            end = 7;
            actual = LinkListNode.RevertPartialLinkList(head, start, end);

            while (actual != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }

            inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            outputArray = new int[] { 4, 3, 2, 1, 5, 6, 7 };
            head = LinkListNode.CreateLinkList(inputArray);
            expected = LinkListNode.CreateLinkList(outputArray);
            start = 1;
            end = 4;
            actual = LinkListNode.RevertPartialLinkList(head, start, end);

            while (actual != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }

            inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            outputArray = new int[] { 1, 2, 3, 7, 6, 5, 4 };
            head = LinkListNode.CreateLinkList(inputArray);
            expected = LinkListNode.CreateLinkList(outputArray);
            start = 4;
            end = 7;
            actual = LinkListNode.RevertPartialLinkList(head, start, end);

            while (actual != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }
               

        }

        /// <summary>
        ///A test for ReverseNodeinKGroup
        ///</summary>
        [TestMethod()]
        public void ReverseNodeinKGroupTest()
        {

            int[] inputArray = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] outputArray = new int[] { 2, 1, 4, 3, 6, 5 };
            LinkListNode head = LinkListNode.CreateLinkList(inputArray);
            LinkListNode expected = LinkListNode.CreateLinkList(outputArray);
            int k = 2;
            LinkListNode actual = LinkListNode.ReverseNodeinKGroup(head, k);

            while (expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }

            inputArray = new int[] { 1, 2, 3, 4, 5, 6 };
            outputArray = new int[] { 3, 2, 1, 6, 5, 4 };
            head = LinkListNode.CreateLinkList(inputArray);
            expected = LinkListNode.CreateLinkList(outputArray);
            k = 3;
            actual = LinkListNode.ReverseNodeinKGroup(head, k);
            while (expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }

            inputArray = new int[] { 1, 2, 3 };
            outputArray = new int[] { 1, 2, 3};
            head = LinkListNode.CreateLinkList(inputArray);
            expected = LinkListNode.CreateLinkList(outputArray);
            k = 6;
            actual = LinkListNode.ReverseNodeinKGroup(head, k);
            while (expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }

            inputArray = new int[] { 1, 2, 3, 4, 5, 6,7,8 };
            outputArray = new int[] { 3, 2, 1, 6, 5, 4,7,8 };
            head = LinkListNode.CreateLinkList(inputArray);
            expected = LinkListNode.CreateLinkList(outputArray);
            k = 3;
            actual = LinkListNode.ReverseNodeinKGroup(head, k);
            while (expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }

            inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            outputArray = new int[] { 8, 7, 6, 5, 4, 3, 2, 1 };
            head = LinkListNode.CreateLinkList(inputArray);
            expected = LinkListNode.CreateLinkList(outputArray);
            k = 8;
            actual = LinkListNode.ReverseNodeinKGroup(head, k);
            while (expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }

            inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            outputArray = new int[] { 8, 7, 6, 5, 4, 3, 2, 1 };
            head = LinkListNode.CreateLinkList(inputArray);
            expected = LinkListNode.CreateLinkList(outputArray);
            k = 8;
            actual = LinkListNode.ReverseNodeinKGroup(null, k);
            Assert.IsNull(actual);


            inputArray = new int[100] ;
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = i + 1;
            }

            outputArray = new int[100];
            for(int i = 0;i < inputArray.Length; i ++)
            {
                outputArray[i] = i + 1;
            }
            for (int i = 0; i < outputArray.Length; i = i + 10)
            {
                for (int j = 0; j < 5; j++)
                {
                    int tmp = outputArray[i+ j];
                    outputArray[i + j] = outputArray[i + 9 - j];
                    outputArray[i + 9 - j] = tmp;
                }
            }
            head = LinkListNode.CreateLinkList(inputArray);
            expected = LinkListNode.CreateLinkList(outputArray);
            k = 10;
            actual = LinkListNode.ReverseNodeinKGroup(head, k);
            while (expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }
        }
    }
}
