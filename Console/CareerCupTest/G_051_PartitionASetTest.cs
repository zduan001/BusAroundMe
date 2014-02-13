using Console2.G_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for G_051_PartitionASetTest and is intended
    ///to contain all G_051_PartitionASetTest Unit Tests
    ///</summary>
    [TestClass()]
    public class G_051_PartitionASetTest
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
        ///A test for PartitionASet
        ///</summary>
        [TestMethod()]
        public void PartitionASetTest()
        {
            G_051_PartitionASet target = new G_051_PartitionASet(); // TODO: Initialize to an appropriate value
            List<int> input = new List<int>() { 1,4,9,16};
            BitArray expected = new BitArray(4,false);
            expected[0] = true;
            expected[3] = true;

            BitArray actual;
            actual = target.PartitionASet(input);
        }
    }
}
