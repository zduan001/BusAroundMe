using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{


    /// <summary>
    ///This is a test class for _057_RestoreIPAddressTest and is intended
    ///to contain all _057_RestoreIPAddressTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _057_RestoreIPAddressTest
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
        ///A test for RestoreIPAddress
        ///</summary>
        [TestMethod()]
        public void RestoreIPAddressTest()
        {
            _057_RestoreIPAddress target = new _057_RestoreIPAddress(); // TODO: Initialize to an appropriate value
            string input = "1234";
            List<string> expected = new List<string>() {"1","2","3","4"};
            List<string> actual = target.RestoreIPAddress(input);

            input = "125324";
            expected = new List<string>() { "1", "2", "3", "4" };
            actual = target.RestoreIPAddress(input);
        }
    }
}
