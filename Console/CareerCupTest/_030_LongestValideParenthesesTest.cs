using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _030_LongestValideParenthesesTest and is intended
    ///to contain all _030_LongestValideParenthesesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _030_LongestValideParenthesesTest
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
        ///A test for FindLongestValideParentheses
        ///</summary>
        [TestMethod()]
        public void FindLongestValideParenthesesTest()
        {
            _030_LongestValideParentheses target = new _030_LongestValideParentheses(); // TODO: Initialize to an appropriate value
            string s = ")(((((()())()()))()(()))(";
            int expected = 22;
            int actual;
            actual = target.FindLongestValideParentheses(s);
            Assert.AreEqual(expected, actual);

            s = ")()())()()(";
            expected = 4;
            actual = target.FindLongestValideParentheses(s);
            Assert.AreEqual(expected, actual);

            s = "((()))())";
            expected = 8;
            actual = target.FindLongestValideParentheses(s);
            Assert.AreEqual(expected, actual);

            s = "(()())";
            expected = 6;
            actual = target.FindLongestValideParentheses(s);
            Assert.AreEqual(expected, actual);
            
        }
    }
}
