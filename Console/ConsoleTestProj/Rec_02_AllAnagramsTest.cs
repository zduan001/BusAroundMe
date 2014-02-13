using Console2.recursion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for Rec_02_AllAnagramsTest and is intended
    ///to contain all Rec_02_AllAnagramsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class Rec_02_AllAnagramsTest
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
        ///A test for GetAllAnagrams
        ///</summary>
        [TestMethod()]
        public void GetAllAnagramsTest()
        {
            Rec_02_AllAnagrams target = new Rec_02_AllAnagrams(); // TODO: Initialize to an appropriate value
            string s = "123";
            List<string> actual;
            actual = target.GetAllAnagrams(s);
            Assert.IsTrue(actual.Contains("123"));
            Assert.IsTrue(actual.Contains("132"));
            Assert.IsTrue(actual.Contains("213"));
            Assert.IsTrue(actual.Contains("231"));
            Assert.IsTrue(actual.Contains("312"));
            Assert.IsTrue(actual.Contains("321"));
        }

        /// <summary>
        ///A test for GetCardCombination
        ///</summary>
        [TestMethod()]
        public void GetCardCombinationTest()
        {
            Rec_02_AllAnagrams target = new Rec_02_AllAnagrams(); // TODO: Initialize to an appropriate value
            int n = 3; 
            int k = 2;
            List<List<int>> actual = target.GetCardCombination(n, k);
            Assert.AreEqual(6, actual.Count);
        }

        /// <summary>
        ///A test for GetAllAnagramsVolAtEnd
        ///</summary>
        [TestMethod()]
        public void GetAllAnagramsVolAtEndTest()
        {
            Rec_02_AllAnagrams target = new Rec_02_AllAnagrams(); // TODO: Initialize to an appropriate value
            string s = "abc";
            List<string> actual = target.GetAllAnagramsVolAtEnd(s);
            Assert.IsTrue(actual.Contains("bca"));
            Assert.IsTrue(actual.Contains("cba"));
            Assert.AreEqual(2, actual.Count);
        }
    }
}
