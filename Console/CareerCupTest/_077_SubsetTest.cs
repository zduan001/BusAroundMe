using Console2.From_076_To_100;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _077_SubsetTest and is intended
    ///to contain all _077_SubsetTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _077_SubsetTest
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
            _077_Subset target = new _077_Subset(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 1, 2, 3 }; 
            List<int[]> actual;
            actual = target.FindAllSubSet(input);
            Assert.AreEqual(8, actual.Count);
        }

        /// <summary>
        ///A test for FindAllSubSet
        ///</summary>
        [TestMethod()]
        public void FindAllSubSetTest1()
        {
            _077_Subset target = new _077_Subset(); // TODO: Initialize to an appropriate value
            List<int> input = new List<int> { 1, 2, 3 };
            List<List<int>> actual;
            actual = target.FindAllSubSet(input);
            Assert.AreEqual(8, actual.Count);
        }

        /// <summary>
        ///A test for FindAllSubSetWithDup
        ///</summary>
        [TestMethod()]
        public void FindAllSubSetWithDupTest()
        {
            _077_Subset target = new _077_Subset(); // TODO: Initialize to an appropriate value
            List<int> input = new List<int> { 1, 2, 2 };
            List<List<int>> actual;
            actual = target.FindAllSubSetWithDup(input);
            Assert.AreEqual(6, actual.Count);
        }
    }
}
