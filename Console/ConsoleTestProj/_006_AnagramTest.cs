using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _006_AnagramTest and is intended
    ///to contain all _006_AnagramTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _006_AnagramTest
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
        ///A test for FindAnagrams
        ///</summary>
        [TestMethod()]
        public void FindAnagramsTest()
        {
            _006_Anagram target = new _006_Anagram(); // TODO: Initialize to an appropriate value
            string[] input = new string[] {"tea","and","ate","eat","dan"};
            List<List<string>> actual = target.FindAnagrams(input);

            Assert.AreEqual(2, actual.Count, "should be 2 group returned");

            foreach (List<string> l in actual)
            {
                if (l.Contains("tea"))
                {
                    Assert.IsTrue(l.Contains("ate"), "tea and ate should be in same group");
                    Assert.IsTrue(l.Contains("eat"), "eat and tea should be in same group");
                    Assert.IsFalse(l.Contains("and"), "and and tea should be in different group");
                }
                if (l.Contains("and"))
                {
                    Assert.IsFalse(l.Contains("tea"), "and and tea should be in different group.");
                    Assert.IsTrue(l.Contains("dan"), "dan and and should be in same group");
                }
            }
        }
    }
}
