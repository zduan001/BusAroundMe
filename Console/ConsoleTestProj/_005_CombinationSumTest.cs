using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _005_CombinationSumTest and is intended
    ///to contain all _005_CombinationSumTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _005_CombinationSumTest
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
        ///A test for FindCombinationSum
        ///</summary>
        [TestMethod()]
        public void FindCombinationSumTest()
        {
            _005_CombinationSum target = new _005_CombinationSum(); // TODO: Initialize to an appropriate value
            int[] array = new [] {2,3,6,7}; 
            int target1 = 7; 
            List<List<int>> actual;
            actual = target.FindCombinationSum(array, target1);
            Assert.AreEqual(2, actual.Count, "there should be 2 list returned");
            foreach (List<int> list in actual)
            {
                int sum = 0;
                foreach (int k in list)
                {
                    sum += k;
                }
                Assert.AreEqual(target1, sum, "Sum should equal to target -- " + target1.ToString());
            }
        }

        /// <summary>
        ///A test for FindCombinationSum
        ///</summary>
        [TestMethod()]
        public void FindCombinationSumTestNull()
        {
            _005_CombinationSum target = new _005_CombinationSum(); // TODO: Initialize to an appropriate value
            int[] array = new[] { 3, 3, 6, 8 };
            int target1 = 7;
            List<List<int>> actual;
            actual = target.FindCombinationSum(array, target1);
            Assert.IsNull(actual, "null should be returned.");
        }

        /// <summary>
        ///A test for FindCombinationSumWithUnique
        ///</summary>
        [TestMethod()]
        public void FindCombinationSumWithUniqueTest()
        {
            _005_CombinationSum target = new _005_CombinationSum(); 
            int[] array = new int[] {10,1,2,7,6,1,5}; 
            int target1 = 8; 
            List<List<int>> actual;
            actual = target.FindCombinationSumWithUnique(array, target1);
            Assert.AreEqual(4, actual.Count, "there should be 4 list returned");
            foreach (List<int> list in actual)
            {
                int sum = 0;
                foreach (int k in list)
                {
                    sum += k;
                }
                Assert.AreEqual(target1, sum, "Sum should equal to target -- " + target1.ToString());
            }
        }
    }
}
