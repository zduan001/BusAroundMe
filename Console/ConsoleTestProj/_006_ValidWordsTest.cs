﻿using console.DP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _006_ValidWordsTest and is intended
    ///to contain all _006_ValidWordsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _006_ValidWordsTest
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
        ///A test for ValidateWords
        ///</summary>
        [TestMethod()]
        public void ValidateWordsTest()
        {
            _006_ValidWords target = new _006_ValidWords();
            HashSet<string> dictionary = new HashSet<string>() { "cat", "dog", "china", "usa", "america", "uk", "ranbow", "rain", "light", "heavy" };
            string s = "usacatdoglight";
            bool expected = true;
            bool actual;
            actual = target.ValidateWords(dictionary, s);
            Assert.AreEqual(expected, actual);

            s = "usaiscatdoglight";
            expected = false;
            actual = target.ValidateWords(dictionary, s);
            Assert.AreEqual(expected, actual);
        }
    }
}
