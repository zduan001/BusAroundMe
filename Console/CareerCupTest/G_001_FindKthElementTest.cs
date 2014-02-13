using Console2.G_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for G_001_FindKthElementTest and is intended
    ///to contain all G_001_FindKthElementTest Unit Tests
    ///</summary>
    [TestClass()]
    public class G_001_FindKthElementTest
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
        ///A test for FindKthElement
        ///</summary>
        [TestMethod()]
        public void FindKthElementTest()
        {
            G_001_FindKthElement target = new G_001_FindKthElement(); // TODO: Initialize to an appropriate value
            int[] a = new int[] { 1, 3, 5, 6, 7, 9, 11 };
            int aStart = 0; 
            int aEnd = 6; 
            int[] b = new int[] { 2, 4, 6, 8, 10, 12 };
            int bStart = 0; 
            int bEnd = 6; 
            int k = 4; 
            int expected = 4; 
            int actual;
            actual = target.FindKthElement(a, aStart, aEnd, b, bStart, bEnd, k);
            Assert.AreEqual(expected, actual);
        }
    }
}
