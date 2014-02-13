using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _040_NextPermutationTest and is intended
    ///to contain all _040_NextPermutationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _040_NextPermutationTest
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
        ///A test for NextPermutation
        ///</summary>
        [TestMethod()]
        public void NextPermutationTest()
        {
            _040_NextPermutation target = new _040_NextPermutation(); // TODO: Initialize to an appropriate value
            string s = "312";
            string expected = "321";
            string actual;
            actual = target.NextPermutation(s);
            Assert.AreEqual(expected, actual);

            s = "547532";
            expected = "552347";
            actual = target.NextPermutation(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
