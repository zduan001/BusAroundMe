using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _073_WordSearchTest and is intended
    ///to contain all _073_WordSearchTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _073_WordSearchTest
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
        ///A test for WordSearch
        ///</summary>
        [TestMethod()]
        public void WordSearchTest()
        {
            /*
            Given board =
            [
             ["ABCE"],
             ["SFCS"],
             ["ADEE"]
            ]
            word = "ABCCED", -> returns true,
            word = "SEE", -> returns true,
            word = "ABCB", -> returns false.
             */

            _073_WordSearch target = new _073_WordSearch(); // TODO: Initialize to an appropriate value
            List<char> tmp1 = new List<char>() {'A', 'B','C', 'E' };
            List<char> tmp2 = new List<char>() { 'S', 'F', 'C', 'S' };
            List<char> tmp3 = new List<char>() { 'A', 'D', 'E', 'E' };
            List<List<char>> board = new List<List<char>>() {tmp1, tmp2, tmp3 };
            string word = "ABCCED"; 
            bool expected = true;
            bool actual = target.WordSearch(board, word);
            Assert.AreEqual(expected, actual, "ABCCED should be true");

            word = "SEE"; 
            expected = true;
            actual = target.WordSearch(board, word);
            Assert.AreEqual(expected, actual, "SEE should be true;");

            word = "ABCX";
            expected = false;
            actual = target.WordSearch(board, word);
            Assert.AreEqual(expected, actual, "ABCB should be false");
        }
    }
}
