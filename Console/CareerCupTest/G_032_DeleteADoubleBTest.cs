using Console2.G_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for G_032_DeleteADoubleBTest and is intended
    ///to contain all G_032_DeleteADoubleBTest Unit Tests
    ///</summary>
    [TestClass()]
    public class G_032_DeleteADoubleBTest
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
        ///A test for DeleteADoubleBII
        ///</summary>
        [TestMethod()]
        public void DeleteADoubleBIITest()
        {
            G_032_DeleteADoubleB target = new G_032_DeleteADoubleB(); // TODO: Initialize to an appropriate value
            string input = "CAABD";
            char del = 'A'; 
            char dou = 'B';
            string expected = "CBBD";
            string actual;
            actual = target.DeleteADoubleBII(input, del, dou);
            Assert.AreEqual(expected, actual);

            input = "CAABDAEFGTHDHYJBAX";
            expected = "CBBDEFGTHDHYJBBX";
            actual = target.DeleteADoubleBII(input, del, dou);
            Assert.AreEqual(expected, actual);
        }
    }
}
