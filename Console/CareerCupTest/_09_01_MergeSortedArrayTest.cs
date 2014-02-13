using CareerCup150.Chapter9_SortingSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _09_01_MergeSortedArrayTest and is intended
    ///to contain all _09_01_MergeSortedArrayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _09_01_MergeSortedArrayTest
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
        ///A test for Merge2Array
        ///</summary>
        [TestMethod()]
        public void Merge2ArrayTest()
        {
            _09_01_MergeSortedArray target = new _09_01_MergeSortedArray(); // TODO: Initialize to an appropriate value
            int[] a1 = new int[] { 1,3,5,7,9,11,0,0,0,0,0,0,};
            int[] a2 = new int[] { 2, 4, 6, 8, 10 };
            int a1length = 5; // TODO: Initialize to an appropriate value
            target.Merge2Array(a1, a2, a1length);
            int k = 1;
            for (int i = 2; i < a1.Length; i++)
            {
                Assert.AreEqual(k++, a1[i]);
            }
        }
    }
}
