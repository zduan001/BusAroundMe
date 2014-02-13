using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _042_PartitionListTest and is intended
    ///to contain all _042_PartitionListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _042_PartitionListTest
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
        ///A test for PartitionList
        ///</summary>
        [TestMethod()]
        public void PartitionListTest()
        {
            _042_PartitionList target = new _042_PartitionList(); // TODO: Initialize to an appropriate value
            LinkListNode input = LinkListNode.CreateLinkList(new int[] { 1, 4, 3, 2, 5, 2 });
            int value = 3; // TODO: Initialize to an appropriate value
            LinkListNode actual;
            actual = target.PartitionList(input, value);
            //1->2->2->4->3->5. 
            Assert.AreEqual(1, actual.Value);
            actual = actual.Next;
            Assert.AreEqual(2, actual.Value);
            actual = actual.Next;
            Assert.AreEqual(2, actual.Value);
            actual = actual.Next;
            Assert.AreEqual(4, actual.Value);
            actual = actual.Next;
            Assert.AreEqual(3, actual.Value);
            actual = actual.Next;
            Assert.AreEqual(5, actual.Value);
            actual = actual.Next;
        }

    }
}
