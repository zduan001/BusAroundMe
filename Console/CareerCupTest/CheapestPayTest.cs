using Console2.recursion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for CheapestPayTest and is intended
    ///to contain all CheapestPayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CheapestPayTest
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
        ///A test for FindCheapestPay
        ///</summary>
        [TestMethod()]
        public void FindCheapestPayTest()
        {
            CheapestPay target = new CheapestPay(); // TODO: Initialize to an appropriate value
            int[] tmp1 = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            int[] tmp2 = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            int[] tmp3 = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            int[] tmp4 = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            int[] tmp5 = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            int[] tmp6 = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            int[] tmp7 = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            List<int[]> Salaris = new List<int[]>() { tmp1, tmp2, tmp3, tmp4, tmp5, tmp6, tmp7 };
            int expected = 0; 
            int actual;
            actual = target.FindCheapestPay(Salaris);
            Assert.AreEqual(expected, actual);
        }
    }
}
