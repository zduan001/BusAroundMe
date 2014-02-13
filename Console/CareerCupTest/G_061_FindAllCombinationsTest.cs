using Console2.G_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for G_061_FindAllCombinationsTest and is intended
    ///to contain all G_061_FindAllCombinationsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class G_061_FindAllCombinationsTest
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
        ///A test for FindAllCombination
        ///</summary>
        [TestMethod()]
        public void FindAllCombinationTest()
        {
            G_061_FindAllCombinations target = new G_061_FindAllCombinations(); // TODO: Initialize to an appropriate value
            int n = 2; // TODO: Initialize to an appropriate value
            int m = 2; // TODO: Initialize to an appropriate value
            int expected = 24; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.FindAllCombination(n, m);
            Assert.AreEqual(expected, actual);
        }
    }
}
