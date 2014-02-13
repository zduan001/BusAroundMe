using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _038_AddOneTest and is intended
    ///to contain all _038_AddOneTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _038_AddOneTest
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
        ///A test for AddOne
        ///</summary>
        [TestMethod()]
        public void AddOneTest()
        {
            _038_AddOne target = new _038_AddOne(); // TODO: Initialize to an appropriate value
            List<int> digits = new List<int>() { 1, 2, 3, 4 };
            List<int> expected = new List<int>() { 1, 2, 3, 5 };
            List<int> actual;
            actual = target.AddOne(digits);
            Assert.AreEqual(actual.Count, expected.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual( expected[i], actual[i]);
            }

            digits = new List<int>() { 1, 2, 3, 9 };
            expected = new List<int>() { 1, 2, 4, 0 };
            actual = target.AddOne(digits);
            Assert.AreEqual(actual.Count, expected.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

            digits = new List<int>() { 1, 2, 9, 9 };
            expected = new List<int>() { 1, 3, 0, 0 };
            actual = target.AddOne(digits);
            Assert.AreEqual(actual.Count, expected.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

            digits = new List<int>() { 9, 9, 9, 9 };
            expected = new List<int>() { 1, 0, 0, 0,0 };
            actual = target.AddOne(digits);
            Assert.AreEqual(actual.Count, expected.Count,"result length is not right");

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
