using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _044_SubsetsTest and is intended
    ///to contain all _044_SubsetsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _044_SubsetsTest
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
        ///A test for FindAllSubSet
        ///</summary>
        [TestMethod()]
        public void FindAllSubSetTest()
        {
            //  expect result:
            //  [ [3], [1], [2], [1,2,3], [1,3], [2,3], [1,2], [] ]
            _044_Subsets target = new _044_Subsets(); // TODO: Initialize to an appropriate value
            List<int> input = new List<int> { 1, 2, 3 };
            List<List<int>> actual = target.FindAllSubSet(input);
            Assert.AreEqual(8, actual.Count);
        }

        /// <summary>
        ///A test for FindAllSubSet2
        ///</summary>
        [TestMethod()]
        public void FindAllSubSet2Test()
        {
            //  expect result:
            //  [ [3], [1], [2], [1,2,3], [1,3], [2,3], [1,2], [] ]
            _044_Subsets target = new _044_Subsets(); // TODO: Initialize to an appropriate value
            List<int> input = new List<int> { 1, 2, 3 };
            List<List<int>> actual = target.FindAllSubSet2(input);
            Assert.AreEqual(8, actual.Count);
        }

        /// <summary>
        ///A test for FindAllSubSet3
        ///</summary>
        [TestMethod()]
        public void FindAllSubSet3Test()
        {
            //  expect result:
            //  [ [3], [1], [2], [1,2,3], [1,3], [2,3], [1,2], [] ]
            _044_Subsets target = new _044_Subsets(); // TODO: Initialize to an appropriate value
            List<int> input = new List<int> { 1, 2, 3 };
            List<List<int>> actual = target.FindAllSubSet3(input);
            Assert.AreEqual(8, actual.Count);
        }


        /// <summary>
        ///A test for SubsetsCombinatoric
        ///</summary>
        [TestMethod()]
        public void SubsetsCombinatoricTest()
        {
            //  expect result:
            //  [ [3], [1], [2], [1,2,3], [1,3], [2,3], [1,2], [] ]
            _044_Subsets target = new _044_Subsets(); // TODO: Initialize to an appropriate value
            List<int> input = new List<int> { 1, 2, 3 };
            List<List<int>> actual = target.SubsetsCombinatoric(input);
            Assert.AreEqual(8, actual.Count);
        }


        /// <summary>
        ///A test for FindSubSetsWithDup
        ///</summary>
        [TestMethod()]
        public void FindSubSetsWithDupTest()
        {
            /// If input = [1,2,2], a solution is:
            /// [ [2], [1], [1,2,2], [2,2], [1,2], [] ]
            _044_Subsets target = new _044_Subsets(); 
            List<int> input = new List<int> { 1, 2, 2 };
            List<List<int>> actual;
            actual = target.FindSubSetsWithDup(input);
            Assert.AreEqual(6, actual.Count);
        }
    }
}
