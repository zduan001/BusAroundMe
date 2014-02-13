using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _046_AtoITest and is intended
    ///to contain all _046_AtoITest Unit Tests
    ///</summary>
    [TestClass()]
    public class _046_AtoITest
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
        ///A test for AtoI
        ///</summary>
        [TestMethod()]
        public void AtoITest()
        {
            _046_AtoI target = new _046_AtoI(); // TODO: Initialize to an appropriate value
            string input = "123"; // TODO: Initialize to an appropriate value
            int expected = 123; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.AtoI(input);
            Assert.AreEqual(expected, actual);


            input = "-123"; 
            expected = -123; 
            actual = target.AtoI(input);
            Assert.AreEqual(expected, actual);

            input = "+123";
            expected = 123;
            actual = target.AtoI(input);
            Assert.AreEqual(expected, actual);

            input = "-123456";
            expected = -123456;
            actual = target.AtoI(input);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        [ExpectedException (typeof(FormatException))]
        public void AtoITestWithExcpetions()
        {

            _046_AtoI target = new _046_AtoI(); // TODO: Initialize to an appropriate value
            string input = "a123"; // TODO: Initialize to an appropriate value
            int expected = 123; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.AtoI(input);
            Assert.AreEqual(expected, actual);

        }

                [TestMethod()]
        [ExpectedException (typeof(FormatException))]
        public void AtoITestWithExcpetions2()
        {

            _046_AtoI target = new _046_AtoI(); // TODO: Initialize to an appropriate value
            string input = "123a999"; // TODO: Initialize to an appropriate value
            int expected = 123; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.AtoI(input);
            Assert.AreEqual(expected, actual);

        }

                [TestMethod()]
        [ExpectedException (typeof(FormatException))]
        public void AtoITestWithExcpetions3()
        {

            _046_AtoI target = new _046_AtoI(); // TODO: Initialize to an appropriate value
            string input = "123b"; // TODO: Initialize to an appropriate value
            int expected = 123; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.AtoI(input);
            Assert.AreEqual(expected, actual);

        }
    }
}
