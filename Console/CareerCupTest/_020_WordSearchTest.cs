using Console2.From_001_To_025;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _020_WordSearchTest and is intended
    ///to contain all _020_WordSearchTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _020_WordSearchTest
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
        ///A test for FindAllWords
        ///</summary>
        [TestMethod()]
        public void FindAllWordsTest()
        {
            _020_WordSearch target = new _020_WordSearch(); // TODO: Initialize to an appropriate value
            char[,] input = new char[,] { 
            { 'A', 'B', 'C', 'E' }, 
            { 'S', 'Y', 'Z', 'S' }, 
            { 'X', 'D', 'V', 'E' }, 
            { 'A', 'D', 'E', 'E' } };
            int n = 4; 
            HashSet<string> dictionary = new HashSet<string>();
            dictionary.Add("XYZV");
            dictionary.Add("aaaa");
            dictionary.Add("XXXX");
            List<string> actual;
            actual = target.FindAllWords(input, n, dictionary);
        }
    }
}
