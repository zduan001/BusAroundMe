﻿using CareerCup150.Chapt1_ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _01_02_RemoveDupFromStringTest and is intended
    ///to contain all _01_02_RemoveDupFromStringTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _01_03_RemoveDupFromStringTest
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
        ///A test for RemoveDup
        ///</summary>
        [TestMethod()]
        public void RemoveDupTest()
        {
            _01_03_RemoveDupFromString target = new _01_03_RemoveDupFromString(); // TODO: Initialize to an appropriate value
            string s = "abgai";
            string expected = "abgi";
            string actual = target.RemoveDup(s);
            Assert.AreEqual(expected, actual);

            s = "abcdbefbghi";
            expected = "abcdefghi";
            actual = target.RemoveDup(s);
            Assert.AreEqual(expected, actual);


            s = "cccccccccccccc";
            expected = "c";
            actual = target.RemoveDup(s);
            Assert.AreEqual(expected, actual);


            s = "cbcbbbcbcbcbcbcbcbcbbbbcccccbcbc";
            expected = "cb";
            actual = target.RemoveDup(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
