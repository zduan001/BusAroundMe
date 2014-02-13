using Console2.From_076_To_100;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _076_SqrtTest and is intended
    ///to contain all _076_SqrtTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _076_SqrtTest
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
        ///A test for FindSqrt
        ///</summary>
        [TestMethod()]
        public void FindSqrtTest()
        {
            _076_Sqrt target = new _076_Sqrt(); // TODO: Initialize to an appropriate value
            int n = 4; // TODO: Initialize to an appropriate value
            double expected = 2.0; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.FindSqrt(n);
            Assert.AreEqual(expected, actual);


            n = 121; 
            expected = 11.0;
            actual = target.FindSqrt(n);
            Assert.IsTrue(Math.Abs(actual - expected) < 0.001);
        }

        /// <summary>
        ///A test for NewtonMethodFindSqrt
        ///</summary>
        [TestMethod()]
        public void NewtonMethodFindSqrtTest()
        {
            _076_Sqrt target = new _076_Sqrt(); // TODO: Initialize to an appropriate value
            int n = 121;
            double expected = 11.0;
            double actual;
            actual = target.NewtonMethodFindSqrt(n);
            Assert.IsTrue(Math.Abs(actual - expected) < 0.001);
        }
    }
}
