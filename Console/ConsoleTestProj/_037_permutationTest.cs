using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _037_permutationTest and is intended
    ///to contain all _037_permutationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _037_permutationTest
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
        ///A test for FindAllPermutation
        ///</summary>
        [TestMethod()]
        public void FindAllPermutationTest()
        {
            _037_permutation target = new _037_permutation();
            List<int> input = new List<int> {1,2,3};
            List<List<int>> actual;
            actual = target.FindAllPermutation(input);
        }

        /// <summary>
        ///A test for FindAllPermutationDP
        ///</summary>
        [TestMethod()]
        public void FindAllPermutationDPTest()
        {
            _037_permutation target = new _037_permutation(); // TODO: Initialize to an appropriate value
            List<int> input = new List<int> { 1, 2, 3 };
            List<List<int>> actual;
            actual = target.FindAllPermutationDP(input);
        }

        /// <summary>
        ///A test for PermutationDP
        ///</summary>
        [TestMethod()]
        public void PermutationDPTest()
        {
            List<int> input = new List<int> { 1, 2, 3 };
            List<List<int>> actual;
            actual = _037_permutation.PermutationDP(input);
            
        }

        /// <summary>
        ///A test for FindAllPermutationWithDuP
        ///</summary>
        [TestMethod()]
        public void FindAllPermutationWithDuPTest()
        {
            _037_permutation target = new _037_permutation(); // TODO: Initialize to an appropriate value
            List<int> input = new List<int> { 1, 2, 1 };
            List<List<int>> actual;
            actual = target.FindAllPermutationWithDuP(input);
        }
    }
}
