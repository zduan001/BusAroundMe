using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _055_ScrambleStringTest and is intended
    ///to contain all _055_ScrambleStringTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _055_ScrambleStringTest
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
        ///A test for IsScrambleString
        ///</summary>
        [TestMethod()]
        public void IsScrambleStringTest()
        {
            _055_ScrambleString target = new _055_ScrambleString(); // TODO: Initialize to an appropriate value
            string s1 = "npfgmkuleygms";
            string s2 = "ygksfmpngumle";
            bool expected = false; 
            bool actual;
            actual = target.IsScrambleString(s1, s2);
            Assert.AreEqual(expected, actual);
            
            s1 = "ab";
            s2 = "ba";
            expected = true;
            actual = target.IsScrambleString(s1, s2);
            Assert.AreEqual(expected, actual);

            s1 = "abc";
            s2 = "acb";
            expected = true;
            actual = target.IsScrambleString(s1, s2);
            Assert.AreEqual(expected, actual);

            s1 = "cbbbc";
            s2 = "cbcbb";
            expected = true;
            actual = target.IsScrambleString(s1, s2);
            Assert.AreEqual(expected, actual);

            s1 = "oyifgtdmeyslstaojpppxvxiavcije";
            s2 = "oaacejivixvxpppjotslsyemdtgfiy";
            expected = true;
            actual = target.IsScrambleString(s1, s2);
            Assert.AreEqual(expected, actual);

            //s1 = "chqtxf";
            //s2 = "qxthcf";
            //expected = true;
            //actual = target.IsScrambleString(s1, s2);
            //Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ScrambleString
        ///</summary>
        [TestMethod()]
        public void ScrambleStringTest()
        {
            _055_ScrambleString target = new _055_ScrambleString(); // TODO: Initialize to an appropriate value
            string s1 = "npfgmkuleygms";
            string s2 = "ygksfmpngumle";
            bool expected = false; 
            bool actual;
            actual = target.ScrambleString(s1, s2);
            Assert.AreEqual(expected, actual);

            s1 = "chqtxf";
            s2 = "qxthcf";
            expected = true;
            actual = target.ScrambleString(s1, s2);
            Assert.AreEqual(expected, actual);
        }
    }
}
