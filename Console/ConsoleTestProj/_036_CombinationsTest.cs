using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _036_CombinationsTest and is intended
    ///to contain all _036_CombinationsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _036_CombinationsTest
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
        ///A test for FindAllCombinations
        ///</summary>
        [TestMethod()]
        public void FindAllCombinationsTest()
        {
            _036_Combinations target = new _036_Combinations(); // TODO: Initialize to an appropriate value
            int n = 3; // TODO: Initialize to an appropriate value
            int k = 2; // TODO: Initialize to an appropriate value
            List<List<int>> actual;
            actual = target.FindAllCombinations(n, k);
            Assert.AreEqual(6, actual.Count);
        }

        /// <summary>
        ///A test for FindAllCombinations
        ///</summary>
        [TestMethod()]
        public void FindAllCombinationsTest1()
        {
            _036_Combinations target = new _036_Combinations(); // TODO: Initialize to an appropriate value
            List<int> input = new List<int> { 1, 2, 3, 4 };
            int k = 2; // TODO: Initialize to an appropriate value
            
            List<List<int>> actual;
            actual = target.FindAllCombinations(input, k);
            Assert.AreEqual(6, actual.Count);
        }
    }
}
