﻿using Console2.From_001_To_025;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _011_CountAndSayTest and is intended
    ///to contain all _011_CountAndSayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _011_CountAndSayTest
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
        ///A test for CountAndSay
        ///</summary>
        [TestMethod()]
        public void CountAndSayTest()
        {
            _011_CountAndSay target = new _011_CountAndSay(); // TODO: Initialize to an appropriate value
            int n = 11; // TODO: Initialize to an appropriate value
            string expected = "11131221133112132113212221";
            string actual = target.CountAndSay(n);
            Assert.AreEqual(expected, actual);
        }
    }
}