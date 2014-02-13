using Console2.G_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for G_018_MixStringsTest and is intended
    ///to contain all G_018_MixStringsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class G_018_MixStringsTest
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
        ///A test for MixStrings
        ///</summary>
        [TestMethod()]
        public void MixStringsTest()
        {
            G_018_MixStrings target = new G_018_MixStrings(); // TODO: Initialize to an appropriate value
            List<string> l1 = new List<string>() {"this", "is", "a", "nice", "house" };
            List<string> l2 = new List<string>() { "a", "brown", "fox", "jump", "over", "fence" };
            string expected = "tahbirsoiwsnafnoixcjeuhmopuosvee";
            string actual;
            actual = target.MixStrings(l1, l2);
            Assert.AreEqual(expected, actual);
        }
    }
}
