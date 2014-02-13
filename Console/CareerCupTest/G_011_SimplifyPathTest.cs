using Console2.G_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for G_011_SimplifyPathTest and is intended
    ///to contain all G_011_SimplifyPathTest Unit Tests
    ///</summary>
    [TestClass()]
    public class G_011_SimplifyPathTest
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
        ///A test for SimplifyPath
        ///</summary>
        [TestMethod()]
        public void SimplifyPathTest()
        {
            G_011_SimplifyPath target = new G_011_SimplifyPath(); // TODO: Initialize to an appropriate value
            string s ="/a/./b///../c/../././../d/..//../e/./f/./g/././//.//h///././/..///"; 
            string expected = "/e/f/g";
            string actual;
            actual = target.SimplifyPath(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
