using Console2.recursion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for Rec_01_MagicSquareTest and is intended
    ///to contain all Rec_01_MagicSquareTest Unit Tests
    ///</summary>
    [TestClass()]
    public class Rec_01_MagicSquareTest
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
        ///A test for CreateAMagicSquare
        ///</summary>
        [TestMethod()]
        public void CreateAMagicSquareTest()
        {
            Rec_01_MagicSquare target = new Rec_01_MagicSquare();
            int n = 3; 
            List<int[]> actual = target.CreateAMagicSquare(n);
            Assert.AreEqual(8, actual.Count);

            n = 4;
            actual = target.CreateAMagicSquare(n);
        }
    }
}
