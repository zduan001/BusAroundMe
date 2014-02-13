using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _043_ReverseIntegerTest and is intended
    ///to contain all _043_ReverseIntegerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _043_ReverseIntegerTest
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
        ///A test for ReverseInteger
        ///</summary>
        [TestMethod()]
        public void ReverseIntegerTest()
        {
            _043_ReverseInteger target = new _043_ReverseInteger(); // TODO: Initialize to an appropriate value
            int input = 123; 
            int expected = 321; 
            int actual = target.ReverseInteger(input);
            Assert.AreEqual(expected, actual);

            input = -123;
            expected = -321;
            actual = target.ReverseInteger(input);
            Assert.AreEqual(expected, actual);

            input = 100;
            expected = 1;
            actual = target.ReverseInteger(input);
            Assert.AreEqual(expected, actual);

            //input = int.MaxValue;
            //expected = 1;
            //actual = target.ReverseInteger(input);
            //Assert.AreEqual(expected, actual);
            
        }
    }
}
