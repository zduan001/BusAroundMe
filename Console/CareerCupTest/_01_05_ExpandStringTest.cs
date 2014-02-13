using CareerCup150.Chapt1_ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _01_05_ExpandStringTest and is intended
    ///to contain all _01_05_ExpandStringTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _01_05_ExpandStringTest
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
        ///A test for ExpandCharArray
        ///</summary>
        [TestMethod()]
        public void ExpandCharArrayTest()
        {
            _01_05_ExpandString target = new _01_05_ExpandString(); // TODO: Initialize to an appropriate value
            char[] input = new char[] {'1', '2', ' ', '3', '4', ' ', '5', '6', '\0', 'x', ' ', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x'  };
            char[] expected = new char[] { '1', '2', '%','2','0', '3', '4', '%', '2', '0', '5', '6', '\0', 'x', ' ', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x' };
            char[] actual = target.ExpandCharArray(input);
            int i = 0;
            while (expected[i] != '\0')
            {
                Assert.AreEqual(expected[i], actual[i]);
                i++;
            }
            Assert.AreEqual(expected[i], actual[i]);
            Assert.AreEqual('\0', actual[i]);
        }
    }
}
