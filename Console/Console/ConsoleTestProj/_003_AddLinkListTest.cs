using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace ConsoleTestProj
{


    /// <summary>
    ///This is a test class for _003_AddLinkListTest and is intended
    ///to contain all _003_AddLinkListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _003_AddLinkListTest
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
        ///A test for AddLinkList
        ///</summary>
        [TestMethod()]
        public void AddLinkListTest()
        {
            _003_AddLinkList target = new _003_AddLinkList(); 
            LinkListNode list1 = LinkListNode.CreateLinkList(new int[] { 1,2,3});
            LinkListNode list2 = LinkListNode.CreateLinkList(new int[] { 1, 2, 3 });
            LinkListNode actual;
            actual = target.AddLinkList(list1, list2);
            Assert.AreEqual(2, actual.Value, "first numer should be 2");
            actual = actual.Next;
            Assert.AreEqual(4, actual.Value, "first numer should be 4");
            actual = actual.Next;
            Assert.AreEqual(6, actual.Value, "first numer should be 4");
            
        }

        /// <summary>
        ///A test for AddLinkList
        ///</summary>
        [TestMethod()]
        public void AddLinkListTestDifferentLength()
        {
            _003_AddLinkList target = new _003_AddLinkList();
            LinkListNode list1 = LinkListNode.CreateLinkList(new int[] { 1, 9, 3, 4, 5 });
            LinkListNode list2 = LinkListNode.CreateLinkList(new int[] { 1, 2, 8 });
            LinkListNode actual;
            actual = target.AddLinkList(list1, list2);
            Assert.AreEqual(2, actual.Value, "first numer should be 2");
            actual = actual.Next;
            Assert.AreEqual(1, actual.Value, "first numer should be 1");
            actual = actual.Next;
            Assert.AreEqual(2, actual.Value, "first numer should be 2");
            actual = actual.Next;
            Assert.AreEqual(5, actual.Value, "first numer should be 5");
            actual = actual.Next;
            Assert.AreEqual(5, actual.Value, "first numer should be 5");
            actual = actual.Next;
            Assert.IsTrue( actual == null, "first numer should be 5");
        }

        /// <summary>
        ///A test for AddLinkList
        ///</summary>
        [TestMethod()]
        public void AddLinkListTestOnelistisNull()
        {
            _003_AddLinkList target = new _003_AddLinkList();
            LinkListNode list1 = null;
            LinkListNode list2 = LinkListNode.CreateLinkList(new int[] { 1, 2, 3 });
            LinkListNode actual;
            actual = target.AddLinkList(list1, list2);
            Assert.AreEqual(1, actual.Value, "first numer should be 2");
            actual = actual.Next;
            Assert.AreEqual(2, actual.Value, "first numer should be 4");
            actual = actual.Next;
            Assert.AreEqual(3, actual.Value, "first numer should be 4");
        }
    }
}
