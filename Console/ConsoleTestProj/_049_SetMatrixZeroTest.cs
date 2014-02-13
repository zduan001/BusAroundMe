using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{


    /// <summary>
    ///This is a test class for _049_SetMatrixZeroTest and is intended
    ///to contain all _049_SetMatrixZeroTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _049_SetMatrixZeroTest
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
        ///A test for SetZerosInMatrix
        ///</summary>
        [TestMethod()]
        public void SetZerosInMatrixTest()
        {
            _049_SetMatrixZero target = new _049_SetMatrixZero(); // TODO: Initialize to an appropriate value
            List<int> tmp1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> tmp2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> tmp3 = new List<int> { 1, 2, 3, 4, 0, 6, 7, 8, 9 };
            List<int> tmp4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> tmp5 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 0, 9 };
            List<int> tmp6 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> tmp7 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<List<int>> input = new List<List<int>> { tmp1, tmp2, tmp3, tmp4, tmp5, tmp6,tmp7 };
            target.SetZerosInMatrix(input);

            for (int i = 0; i < input[0].Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (i == 4 || j == 2 ||j==4 || i == 7)
                    {
                        Assert.AreEqual(0, input[j][i], "element j " + j.ToString() + " i " + i.ToString() + "should be 0");
                    }
                    else
                    {
                        Assert.IsTrue(input[j][i] != 0, "element j " + j.ToString() + " i " + i.ToString() + "should not be 0");
                    }
                }
            }
        }
    }
}
