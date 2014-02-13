using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _047_SortColorTest and is intended
    ///to contain all _047_SortColorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _047_SortColorTest
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
        ///A test for SortColorWithOnePass
        ///</summary>
        [TestMethod()]
        public void SortColorWithOnePassTest()
        {
            _047_SortColor target = new _047_SortColor(); // TODO: Initialize to an appropriate value
            int[] input = new int[] {0,1,2,0,1,2,0,1,2};
            int[] expected = new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 2 };
            target.SortColorWithOnePass(input);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], input[i]);
            }


            input = new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 2 };
            expected = new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 2 };
            target.SortColorWithOnePass(input);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], input[i]);
            }

            input = new int[] { 1, 1, 0, 1, 1, 1, 2, 1, 1 };
            expected = new int[] { 0, 1, 1, 1, 1, 1, 1, 1, 2 };
            target.SortColorWithOnePass(input);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], input[i]);
            }
            
        }
    }
}
