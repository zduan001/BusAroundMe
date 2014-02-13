using Console2.From_026_To_050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _033_MergeIntervalsTest and is intended
    ///to contain all _033_MergeIntervalsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _033_MergeIntervalsTest
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
        ///A test for MergeIntervals
        ///</summary>
        [TestMethod()]
        public void MergeIntervalsTest()
        {
            _033_MergeIntervals target = new _033_MergeIntervals(); // TODO: Initialize to an appropriate value
            Interval i2 = new Interval(2,3);
            Interval i3 = new Interval(4,5);
            Interval i4 = new Interval(6,7);
            Interval i5 = new Interval(8,9);
            Interval i1 = new Interval(1,5);

            Interval[] input = new Interval[] { i1, i2, i3, i4, i5 };
            List<Interval> actual;
            actual = target.MergeIntervals(input);
            Assert.AreEqual(3, actual.Count);


            //---------------------------------
            // Case 2
            //---------------------------------
            i2 = new Interval(2, 3);
            i3 = new Interval(4, 7);
            i5 = new Interval(8, 9);
            i1 = new Interval(1, 5);

            input = new Interval[] { i1, i2, i3, i5 };
            actual = target.MergeIntervals(input);
            Assert.AreEqual(2, actual.Count);

            //---------------------------------
            // Case 2
            //---------------------------------
            i2 = new Interval(2, 3);
            i3 = new Interval(4, 7);
            i5 = new Interval(8, 9);
            i1 = new Interval(1, 10);

            input = new Interval[] { i1, i2, i3, i5 };
            actual = target.MergeIntervals(input);
            Assert.AreEqual(1, actual.Count);
        }
    }
}
