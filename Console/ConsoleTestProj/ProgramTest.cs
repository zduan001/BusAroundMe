using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{


    /// <summary>
    ///This is a test class for ProgramTest and is intended
    ///to contain all ProgramTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProgramTest
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
        ///A test for Find3Sum
        ///</summary>
        [TestMethod()]
        [DeploymentItem("3sum.exe")]
        public void Find3SumTest()
        {
            int[] inputArray = new int[] { 1, -1, 0 };
            List<int> list = new List<int> { 1, -1, 0 };
            HashSet<List<int>> expected = new HashSet<List<int>>() { list };

            HashSet<List<int>> actual;
            actual = Program_Accessor.Find3Sum(inputArray);
            Assert.AreEqual(1, actual.Count, "expect {1,-1,0}");

            List<int>[] ret = new List<int>[100];
            actual.CopyTo(ret);
            Assert.IsTrue(ret[0].Contains(1), "should contains 1");
            Assert.IsTrue(ret[0].Contains(-1), "should contains -1");
            Assert.IsTrue(ret[0].Contains(0), "should contains 0");
        }

        /// <summary>
        ///A test for Find3Sum
        ///</summary>
        [TestMethod()]
        [DeploymentItem("3sum.exe")]
        public void Find3SumLongArrayTest()
        {
            int[] inputArray = new int[] { 1, -1, 0, 2, 3, -3, -2, -1, 5, 3 };

            HashSet<List<int>> actual;
            actual = Program.Find3Sum(inputArray);
            Assert.AreEqual(7, actual.Count, "expect {1,-1,0}");
        }

        /// <summary>
        ///A test for Find3Sum
        ///</summary>
        [TestMethod()]
        [DeploymentItem("3sum.exe")]
        public void Find3SumShortArrayTest()
        {
            int[] inputArray = new int[] { 1, -1};

            HashSet<List<int>> actual;
            actual = Program.Find3Sum(inputArray);
            Assert.AreEqual(0, actual.Count, "expect {1,-1,0}");

        }

        /// <summary>
        ///A test for Find3Sum
        ///</summary>
        [TestMethod()]
        [DeploymentItem("3sum.exe")]
        public void Find3SumNotExistArrayTest()
        {
            int[] inputArray = new int[] { 1, -1, 5, 7, 3 , 9 , 10 };

            HashSet<List<int>> actual;
            actual = Program.Find3Sum(inputArray);
            Assert.AreEqual(0, actual.Count, "expect {1,-1,0}");

        }

        /// <summary>
        ///A test for FindClosest3Sum
        ///</summary>
        [TestMethod()]
        public void FindClosest3SumTest()
        {
            int[] inputArray = new int [] { 1, -1, 5, 7, 3 , 9 , 10 };
            int value = 0; // TODO: Initialize to an appropriate value
            
            List<int> actual;
            actual = Program.FindClosest3Sum(inputArray, value);

            Assert.IsTrue(actual.Contains(1), "contains 1");
            Assert.IsTrue(actual.Contains(-1), "contains -1");
            Assert.IsTrue(actual.Contains(3), "contains 3");
        }

        /// <summary>
        ///A test for FindClosest3Sum
        ///</summary>
        [TestMethod()]
        public void FindClosest3SumTestWithEqualResult()
        {
            int[] inputArray = new int[] { 2, -1, 5, 7, 3, 9, -10 };
            int value = 0; // TODO: Initialize to an appropriate value

            List<int> actual;
            actual = Program.FindClosest3Sum(inputArray, value);

            Assert.IsTrue(actual.Contains(7), "contains 7");
            Assert.IsTrue(actual.Contains(-10), "contains -10");
            Assert.IsTrue(actual.Contains(3), "contains 3");
        }

        /// <summary>
        ///A test for FindClosest3Sum
        ///</summary>
        [TestMethod()]
        public void FindClosest3SumTestshortArray()
        {
            int[] inputArray = new int[] { 2, -1};
            int value = 0; // TODO: Initialize to an appropriate value

            List<int> actual;
            actual = Program.FindClosest3Sum(inputArray, value);

            Assert.AreEqual(0, actual.Count, "Should contains no retsult");
        }
    }
}
