using Console2.G_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for G_062_Find3IndexTest and is intended
    ///to contain all G_062_Find3IndexTest Unit Tests
    ///</summary>
    [TestClass()]
    public class G_062_Find3IndexTest
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
        ///A test for Find3Index
        ///</summary>
        [TestMethod()]
        public void Find3IndexTest()
        {
            G_062_Find3Index target = new G_062_Find3Index(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 5, 1, 4, 3, 2, 6, -1};
            List<int> expected = new List<int>() {1, 2, 5 };
            List<int> actual;
            actual = target.Find3Index(input);
            Assert.AreEqual(expected, actual);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
