using CareerCup150.Chapter3_StacksAndQueues;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _03_06_SortStackTest and is intended
    ///to contain all _03_06_SortStackTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _03_06_SortStackTest
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
        ///A test for SortStack
        ///</summary>
        [TestMethod()]
        public void SortStackTest()
        {
            _03_06_SortStack target = new _03_06_SortStack(); // TODO: Initialize to an appropriate value
            Stack<int> s = new Stack<int>();
            s.Push(10);
            s.Push(6);
            s.Push(8);
            s.Push(2);
            s.Push(5);
            s.Push(4);
            s.Push(9);
            s.Push(3);
            s.Push(1);
            s.Push(7);

            Stack<int> actual;
            actual = target.SortStack(s);
            while (actual.Count != 1)
            {
                Assert.IsTrue(actual.Pop() > actual.Peek());
            }
        }
    }
}
