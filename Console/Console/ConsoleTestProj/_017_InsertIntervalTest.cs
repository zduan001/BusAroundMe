using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _017_InsertIntervalTest and is intended
    ///to contain all _017_InsertIntervalTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _017_InsertIntervalTest
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
        ///A test for InsertInterval
        ///</summary>
        [TestMethod()]
        public void InsertIntervalTest()
        {
            _017_InsertInterval target = new _017_InsertInterval(); 
            Interval[] intervals = new Interval[] { }; 
            Interval newInterval = new Interval(5,7); 
            Interval[] actual;
            actual = target.InsertInterval(intervals, newInterval);
            Assert.AreEqual(1, actual.Length);
            Assert.AreEqual(newInterval.Start, actual[0].Start);
            Assert.AreEqual(newInterval.End, actual[0].End);
            
            intervals = new Interval[] { new Interval(1,5)};
            newInterval = new Interval(2,3);
            actual = target.InsertInterval(intervals, newInterval);
            Assert.AreEqual(1, actual.Length);
            Assert.AreEqual(1, actual[0].Start);
            Assert.AreEqual(5, actual[0].End);

            intervals = new Interval[] { new Interval(1, 5) };
            newInterval = new Interval(2, 7);
            actual = target.InsertInterval(intervals, newInterval);
            Assert.AreEqual(1, actual.Length);
            Assert.AreEqual(1, actual[0].Start);
            Assert.AreEqual(7, actual[0].End);

            intervals = new Interval[] { new Interval(1, 5) };
            newInterval = new Interval(6, 8);
            actual = target.InsertInterval(intervals, newInterval);
            Assert.AreEqual(2, actual.Length);
            Assert.AreEqual(1, actual[0].Start);
            Assert.AreEqual(5, actual[0].End);
            Assert.AreEqual(6, actual[1].Start);
            Assert.AreEqual(8, actual[1].End);

            intervals = new Interval[] { new Interval(1, 4), new Interval(6, 6), new Interval(8, 10) };
            newInterval = new Interval(11,11);
            actual = target.InsertInterval(intervals, newInterval);
            Assert.AreEqual(4, actual.Length);
            Assert.AreEqual(1, actual[0].Start);
            Assert.AreEqual(4, actual[0].End);
            Assert.AreEqual(6, actual[1].Start);
            Assert.AreEqual(6, actual[1].End);
            Assert.AreEqual(11, actual[3].Start);
            Assert.AreEqual(11, actual[3].End);

            intervals = new Interval[] { new Interval(1, 4), new Interval(6, 6), new Interval(8, 10) };
            newInterval = new Interval(1, 11);
            actual = target.InsertInterval(intervals, newInterval);
            Assert.AreEqual(1, actual.Length);
            Assert.AreEqual(1, actual[0].Start);
            Assert.AreEqual(11, actual[0].End);

        }
    }
}
