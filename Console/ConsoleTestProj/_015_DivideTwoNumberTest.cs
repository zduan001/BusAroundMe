using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _015_DivideTwoNumberTest and is intended
    ///to contain all _015_DivideTwoNumberTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _015_DivideTwoNumberTest
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
        ///A test for Divide
        ///</summary>
        [TestMethod()]
        public void DivideTest()
        {
            //2147483647, 3 0 715827882 
            _015_DivideTwoNumber target = new _015_DivideTwoNumber(); // TODO: Initialize to an appropriate value
            int dividen = 2147483647;
            int dividor = 3; 
            int expected = 715827882; 
            int actual;
            actual = target.Divide(dividen, dividor);
            Assert.AreEqual(expected, actual);

            dividen = -2147483647;
            dividor = 3;
            expected = -715827882;
            actual = target.Divide(dividen, dividor);
            Assert.AreEqual(expected, actual);

            dividen = -2147483647;
            dividor = -3;
            expected = 715827882;
            actual = target.Divide(dividen, dividor);
            Assert.AreEqual(expected, actual);

            dividen = 2147483647;
            dividor = -3;
            expected = -715827882;
            actual = target.Divide(dividen, dividor);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for DivideFast
        ///</summary>
        [TestMethod()]
        public void DivideFastTest()
        {
            _015_DivideTwoNumber target = new _015_DivideTwoNumber(); // TODO: Initialize to an appropriate value
            int dividen = 2147483647;
            int dividor = 3;
            int expected = 715827882;
            int actual;
            actual = target.DivideFast(dividen, dividor);
            Assert.AreEqual(expected, actual);

            dividen = -2147483647;
            dividor = 3;
            expected = -715827882;
            actual = target.DivideFast(dividen, dividor);
            Assert.AreEqual(expected, actual);

            dividen = -2147483647;
            dividor = -3;
            expected = 715827882;
            actual = target.DivideFast(dividen, dividor);
            Assert.AreEqual(expected, actual);

            dividen = 2147483647;
            dividor = -3;
            expected = -715827882;
            actual = target.DivideFast(dividen, dividor);
            Assert.AreEqual(expected, actual);
        }
    }
}
