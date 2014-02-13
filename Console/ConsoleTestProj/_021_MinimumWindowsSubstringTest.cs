using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _021_MinimumWindowsSubstringTest and is intended
    ///to contain all _021_MinimumWindowsSubstringTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _021_MinimumWindowsSubstringTest
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
        ///A test for FindMinWindowSubstrring
        ///</summary>
        [TestMethod()]
        public void FindMinWindowSubstrringTest()
        {
            _021_MinimumWindowsSubstring target = new _021_MinimumWindowsSubstring(); // TODO: Initialize to an appropriate value

            string s = "ADOBECODEBANC";
            string t = "ABC";
            string expected = "BANC";
            string actual;
            actual = target.FindMinWindowSubstrring(s, t);
            Assert.AreEqual(expected, actual);

            s = "adobecodebanc";
            t = "abcda";
            expected = "adobecodeba";
            actual = target.FindMinWindowSubstrring(s, t);
            Assert.AreEqual(expected, actual);


            s = "of_characters_and_as";
            t = "aas"; 
            expected = "and_as"; 
            actual = target.FindMinWindowSubstrring(s, t);
            Assert.AreEqual(expected, actual);
        }
    }
}
