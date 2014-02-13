using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _011_GenerateParentheseTest and is intended
    ///to contain all _011_GenerateParentheseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _011_GenerateParentheseTest
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
        ///A test for GenerateParenThese
        ///</summary>
        [TestMethod()]
        public void GenerateParenTheseTest()
        {
            _011_GenerateParenthese target = new _011_GenerateParenthese(); // TODO: Initialize to an appropriate value
            int input = 3; // TODO: Initialize to an appropriate value
            List<string> actual;
            actual = target.GenerateParenThese(input);
            Assert.AreEqual(5, actual.Count, "should be 5 strings");
            Assert.IsTrue(actual.Contains("((()))"));
            Assert.IsTrue(actual.Contains("(()())"));
            Assert.IsTrue(actual.Contains("(())()"));
            Assert.IsTrue(actual.Contains("()(())"));
            Assert.IsTrue(actual.Contains("()()()"));
            
        }
    }
}
