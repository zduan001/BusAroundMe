using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _053_AllPermutationTest and is intended
    ///to contain all _053_AllPermutationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _053_AllPermutationTest
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
        ///A test for GetAllPermutation
        ///</summary>
        [TestMethod()]
        public void GetAllPermutationTest()
        {
            _053_AllPermutation target = new _053_AllPermutation(); // TODO: Initialize to an appropriate value
            int[] input = new[] { 1, 2, 3 };
            List<int[]> actual;
            actual = target.GetAllPermutation(input);
            Assert.AreEqual(6, actual.Count);

            input = new[] { 1, 1, 2 };
            actual = target.GetAllPermutation(input);
            Assert.AreEqual(3, actual.Count);
        }

        /// <summary>
        ///A test for GetAllPermutationDP
        ///</summary>
        [TestMethod()]
        public void GetAllPermutationDPTest()
        {
            _053_AllPermutation target = new _053_AllPermutation(); // TODO: Initialize to an appropriate value
            List<int> input = new List<int>() { 1, 2, 3 };
            List<List<int>> actual;
            actual = target.GetAllPermutationDP(input);
            Assert.AreEqual(6, actual.Count);
        }
    }
}
