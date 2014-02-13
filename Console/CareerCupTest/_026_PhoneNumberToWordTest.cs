using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _026_PhoneNumberToWordTest and is intended
    ///to contain all _026_PhoneNumberToWordTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _026_PhoneNumberToWordTest
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
        ///A test for PhoneNumberToWord
        ///</summary>
        [TestMethod()]
        public void PhoneNumberToWordTest()
        {
            _026_PhoneNumberToWord target = new _026_PhoneNumberToWord(); // TODO: Initialize to an appropriate value
            int input = 432;
            List<string> expected = new List<string>() { "gad", "gae", "gaf", "gbd", "gbe", "gbf", "gcd", "gce", "gcf", "had", "hae", "haf", "hbd", "hbe", "hbf", "hcd", "hce", "hcf", "iad", "iae", "iaf", "ibd", "ibe", "ibf", "icd", "ice", "icf" };
            List<string> actual;
            actual = target.PhoneNumberToWord(input);
            Assert.AreEqual(expected.Count, actual.Count);
            
        }
    }
}
