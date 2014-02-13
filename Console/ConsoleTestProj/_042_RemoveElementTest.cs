using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{


    /// <summary>
    ///This is a test class for _042_RemoveElementTest and is intended
    ///to contain all _042_RemoveElementTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _042_RemoveElementTest
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
        ///A test for RemoveElement
        ///</summary>
        [TestMethod()]
        public void RemoveElementTest()
        {
            _042_RemoveElement target = new _042_RemoveElement(); // TODO: Initialize to an appropriate value
            int[] input = null; // TODO: Initialize to an appropriate value
            int key = 10; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.RemoveElement(input, key);
            Assert.AreEqual(expected, actual);

            input = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            key = 1;
            expected = 0; // TODO: Initialize to an appropriate value
            actual = target.RemoveElement(input, key);
            Assert.AreEqual(expected, actual);

            input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 1 };
            key = 1;
            expected = 7; // TODO: Initialize to an appropriate value
            actual = target.RemoveElement(input, key);
            Assert.AreEqual(expected, actual);

            input = new int[] { 1, 1, 2, 3, 4, 5, 6, 7, 8, 1 };
            key = 1;
            expected = 7; // TODO: Initialize to an appropriate value
            actual = target.RemoveElement(input, key);
            Assert.AreEqual(expected, actual);


            input = new int[] { 1, 2, 1, 3, 1, 4, 1, 5, 1, 6, 1, 7, 1, 8, 1 };
            key = 1;
            expected = 7; // TODO: Initialize to an appropriate value
            actual = target.RemoveElement(input, key);
            Assert.AreEqual(expected, actual);

            input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 1, 1, 1, 1, 1, 1, 1 };
            key = 1;
            expected = 7; // TODO: Initialize to an appropriate value
            actual = target.RemoveElement(input, key);
            Assert.AreEqual(expected, actual);

            input = new int[] { };
            key = 1;
            expected = 0; // TODO: Initialize to an appropriate value
            actual = target.RemoveElement(input, key);
            Assert.AreEqual(expected, actual);
        }
    }
}
