using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _022__MinSumPathTest and is intended
    ///to contain all _022__MinSumPathTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _022__MinSumPathTest
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
        ///A test for FindMinSumPath
        ///</summary>
        [TestMethod()]
        public void FindMinSumPathTest()
        {
            _022__MinSumPath target = new _022__MinSumPath(); // TODO: Initialize to an appropriate value
            List<List<int>> input = new List<List<int>>(){ new List<int>(){1,2,3},new List<int>(){4,5,6}};
            int expected = 12; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.FindMinSumPath(input);
            Assert.AreEqual(expected, actual);


            input = new List<List<int>>() { new List<int>() {1,4,8,6,2,2,1,7},
                new List<int>() {4,7,3,1,4,5,5,1},
                new List<int>() {8,8,2,1,1,8,0,1},
                new List<int>() {8,9,2,9,8,0,8,9},
                new List<int>() {5,7,5,7,1,8,5,5},
                new List<int>() {7,0,9,4,5,6,5,6},
                new List<int>() {4,9,9,7,9,1,9,0}};
            expected = 47; 
            actual = target.FindMinSumPath(input);
            Assert.AreEqual(expected, actual);
            
        }
    }
}
