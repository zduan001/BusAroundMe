using Console2.From_001_To_025;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Infra;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _021_ContructBSTFromPostOrderArrayTest and is intended
    ///to contain all _021_ContructBSTFromPostOrderArrayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _021_ContructBSTFromPostOrderArrayTest
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
        ///A test for CreateBST
        ///</summary>
        [TestMethod()]
        public void CreateBSTTest()
        {
            _021_ContructBSTFromPostOrderArray target = new _021_ContructBSTFromPostOrderArray(); // TODO: Initialize to an appropriate value
            int[] input = new int[] {1, 6,8,7,5 };
            TreeNode actual = target.CreateBST(input);
            Assert.AreEqual(5, actual.Value);
            Assert.AreEqual(1, actual.LeftChild.Value);
            Assert.AreEqual(7, actual.RightChild.Value);
            Assert.AreEqual(6, actual.RightChild.LeftChild.Value);
            Assert.AreEqual(8, actual.RightChild.RightChild.Value);

            input = new int[] { 1,4,3, 6, 8, 7, 5 };
            actual = target.CreateBST(input);
            Assert.AreEqual(5, actual.Value);
            Assert.AreEqual(3, actual.LeftChild.Value);
            Assert.AreEqual(1, actual.LeftChild.LeftChild.Value);
            Assert.AreEqual(4, actual.LeftChild.RightChild.Value);
            Assert.AreEqual(7, actual.RightChild.Value);
            Assert.AreEqual(6, actual.RightChild.LeftChild.Value);
            Assert.AreEqual(8, actual.RightChild.RightChild.Value);

            input = new int[] { 1, 4, 3100, 84375, 6, 8, 7, 5 };
            //actual = target.CreateBST(input);
            //Assert.IsNull(actual);
        }

        /// <summary>
        ///A test for VerifyPostOrder
        ///</summary>
        [TestMethod()]
        public void VerifyPostOrderTest()
        {
            _021_ContructBSTFromPostOrderArray target = new _021_ContructBSTFromPostOrderArray(); // TODO: Initialize to an appropriate value
            int[] input = new int[] {1, 6,8,7,5 };
            bool expected = true;
            bool actual = target.VerifyPostOrder(input);
            Assert.AreEqual(expected, actual);


            input = new int[] { 1,100, 6, 8, 7, 5 };
            expected = false;
            actual = target.VerifyPostOrder(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
