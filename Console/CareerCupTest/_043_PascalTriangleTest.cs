using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _043_PascalTriangleTest and is intended
    ///to contain all _043_PascalTriangleTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _043_PascalTriangleTest
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
        ///A test for PascalTriangle
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Console2.dll")]
        public void PascalTriangleTest()
        {
            _043_PascalTriangle_Accessor target = new _043_PascalTriangle_Accessor(); // TODO: Initialize to an appropriate value
            int n = 0; // TODO: Initialize to an appropriate value
            List<List<int>> expected = null; // TODO: Initialize to an appropriate value
            List<List<int>> actual;
            actual = target.PascalTriangle(n);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PascalTriangle
        ///</summary>
        [TestMethod()]
        public void PascalTriangleTest1()
        {
            _043_PascalTriangle target = new _043_PascalTriangle(); // TODO: Initialize to an appropriate value
            int n = 5; // TODO: Initialize to an appropriate value
            List<List<int>> actual;
            actual = target.PascalTriangle(n);
            Assert.AreEqual(5, actual.Count);
        }

        /// <summary>
        ///A test for psacalTriangleII
        ///</summary>
        [TestMethod()]
        public void psacalTriangleIITest()
        {
            _043_PascalTriangle target = new _043_PascalTriangle(); // TODO: Initialize to an appropriate value
            int n = 5; // TODO: Initialize to an appropriate value
            List<int> actual;
            actual = target.psacalTriangleII(n);
            Assert.AreEqual(1, actual[0]);
            Assert.AreEqual(4, actual[1]);
            Assert.AreEqual(6, actual[2]);
            Assert.AreEqual(4, actual[3]);
            Assert.AreEqual(1, actual[4]);
        }
    }
}
