using CareerCup150.Chapter4_TreeGraph;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _04_02_DriectGraphTest and is intended
    ///to contain all _04_02_DriectGraphTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _04_02_DriectGraphTest
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
        ///A test for FindIf2NodesConnected
        ///</summary>
        [TestMethod()]
        public void FindIf2NodesConnectedTest()
        {
            _04_02_DriectGraph target = new _04_02_DriectGraph(); // TODO: Initialize to an appropriate value
            List<int> tmp1 = new List<int>() { 2, 3, 4 };
            List<int> tmp2 = new List<int>() { 4 };
            List<int> tmp3 = new List<int>() { 2, 4 };
            List<int> tmp4 = new List<int>() { 5 };


            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            graph.Add(1, tmp1);
            graph.Add(2, tmp2);
            graph.Add(3, tmp3);
            graph.Add(4, tmp4);

            int start = 1; // TODO: Initialize to an appropriate value
            int end = 5; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.FindIf2NodesConnected(graph, start, end);
            Assert.AreEqual(expected, actual);
        }
    }
}
