using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _041_IsPalindromeNumberTest and is intended
    ///to contain all _041_IsPalindromeNumberTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _041_IsPalindromeNumberTest
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
        ///A test for PalindromeNumberChecker
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Console2.dll")]
        public void PalindromeNumberCheckerTest()
        {
            _041_IsPalindromeNumber_Accessor target = new _041_IsPalindromeNumber_Accessor(); // TODO: Initialize to an appropriate value
            int x = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.PalindromeNumberChecker(x);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PalindromeNumberChecker
        ///</summary>
        [TestMethod()]
        public void PalindromeNumberCheckerTest1()
        {
            _041_IsPalindromeNumber target = new _041_IsPalindromeNumber(); // TODO: Initialize to an appropriate value
            int x = 12321;
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.PalindromeNumberChecker(x);
            Assert.AreEqual(expected, actual);

            x = 123211;
            expected = false; // TODO: Initialize to an appropriate value
            actual = target.PalindromeNumberChecker(x);
            Assert.AreEqual(expected, actual);
        }
    }
}
