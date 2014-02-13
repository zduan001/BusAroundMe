using Console2.From_001_To_025;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _017_GrayCodeTest and is intended
    ///to contain all _017_GrayCodeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _017_GrayCodeTest
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
        ///A test for GenerateGrayCode
        ///</summary>
        [TestMethod()]
        public void GenerateGrayCodeTest()
        {
            _017_GrayCode target = new _017_GrayCode(); // TODO: Initialize to an appropriate value
            int n = 2; 
            List<int> actual = target.GenerateGrayCode(n);

            Assert.IsTrue(actual.Contains(0));
            Assert.IsTrue(actual.Contains(1));
            Assert.IsTrue(actual.Contains(2));
            Assert.IsTrue(actual.Contains(3));

            n = 3;
            actual = target.GenerateGrayCode(n);

            Assert.IsTrue(actual.Contains(0));
            Assert.IsTrue(actual.Contains(1));
            Assert.IsTrue(actual.Contains(2));
            Assert.IsTrue(actual.Contains(3));
            Assert.IsTrue(actual.Contains(4));
            Assert.IsTrue(actual.Contains(5));
            Assert.IsTrue(actual.Contains(6));
            Assert.IsTrue(actual.Contains(7));
        }
    }
}
