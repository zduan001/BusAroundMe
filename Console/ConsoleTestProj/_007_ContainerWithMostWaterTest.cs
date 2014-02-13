using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _007_ContainerWithMostWaterTest and is intended
    ///to contain all _007_ContainerWithMostWaterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _007_ContainerWithMostWaterTest
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
        ///A test for FindLargestContainerBrutal
        ///</summary>
        [TestMethod()]
        public void FindLargestContainerBrutalTest()
        {
            _007_ContainerWithMostWater target = new _007_ContainerWithMostWater(); // TODO: Initialize to an appropriate value
            
            List<int> actual, actualbrutal;

            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            actualbrutal = target.FindLargestContainerBrutal(input);
            actual = target.FindLargestContainer(input);
            Assert.AreEqual(25, actual[0], "max capacity should be 25");
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], actualbrutal[i], "brutal force and one way scan should come out with same solution");
            }


            input = new int[] { 2,3,10,5,7,8,9 };
            actualbrutal = target.FindLargestContainerBrutal(input);
            actual = target.FindLargestContainer(input);
            Assert.AreEqual(36, actual[0], "max capacity should be 25");
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], actualbrutal[i], "brutal force and one way scan should come out with same solution");
            }
            
        }
    }
}
