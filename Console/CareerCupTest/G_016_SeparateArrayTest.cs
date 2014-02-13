using Console2.G_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for G_016_SeparateArrayTest and is intended
    ///to contain all G_016_SeparateArrayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class G_016_SeparateArrayTest
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
        ///A test for SeparateArray
        ///</summary>
        [TestMethod()]
        public void SeparateArrayTest()
        {
            G_016_SeparateArray target = new G_016_SeparateArray(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 9, 4,8,4,3,4,5,6,4,8,7,2,1};
            int value = 4; 
            target.SeparateArray(input, value);

            for (int i = 0; i < input.Length; i++)
            {
                if (i <= 2)
                {
                    Assert.IsTrue(input[i] < value);
                }
                if (i > 2 && i <= 6)
                {
                    Assert.IsTrue(input[i] == value);
                }
                if (i > 6)
                {
                    Assert.IsTrue(input[i] > value);
                }
            }
        }
    }
}
