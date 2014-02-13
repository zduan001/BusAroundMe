using Console2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _002_AddingBinary_Round2Test and is intended
    ///to contain all _002_AddingBinary_Round2Test Unit Tests
    ///</summary>
    [TestClass()]
    public class _002_AddingBinary_Round2Test
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
        ///A test for AddBinaryString
        ///</summary>
        [TestMethod()]
        public void AddBinaryStringTest()
        {
            _002_AddingBinary_Round2 target = new _002_AddingBinary_Round2();
            string s1 = "0101";
            string s2 = "1101";
            string expected = "10101";
            string actual = target.AddBinaryString(s1, s2);
            Assert.AreEqual(expected, actual);

            s1 = "1111";
            s2 = "1111";
            expected = "01111";
            actual = target.AddBinaryString(s1, s2);
            Assert.AreEqual(expected, actual);

            s1 = "11";
            s2 = "101111";
            expected = "0000001";
            actual = target.AddBinaryString(s1, s2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AddBinaryStringRightOrder
        ///</summary>
        [TestMethod()]
        public void AddBinaryStringRightOrderTest()
        {
            _002_AddingBinary_Round2 target = new _002_AddingBinary_Round2(); // TODO: Initialize to an appropriate value
            string s1 = "1010";
            string s2 = "1011";
            string expected = "10101";
            string actual;
            actual = target.AddBinaryStringRightOrder(s1, s2);
            Assert.AreEqual(expected, actual);


            s1 = "1111";
            s2 = "1111";
            expected = "11110";
            actual = target.AddBinaryStringRightOrder(s1, s2);
            Assert.AreEqual(expected, actual);

            s1 = "11";
            s2 = "111101";
            expected = "1000000";
            actual = target.AddBinaryStringRightOrder(s1, s2);
            Assert.AreEqual(expected, actual);
        }
    }
}
