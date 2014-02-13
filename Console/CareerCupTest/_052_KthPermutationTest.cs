using Console2.From_051_To_75;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for _052_KthPermutationTest and is intended
    ///to contain all _052_KthPermutationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _052_KthPermutationTest
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
        ///A test for FindKthPermutation
        ///</summary>
        [TestMethod()]
        public void FindKthPermutationTest()
        {
            _052_KthPermutation target = new _052_KthPermutation(); // TODO: Initialize to an appropriate value
            int n = 4; // TODO: Initialize to an appropriate value
            int k = 1; // TODO: Initialize to an appropriate value
            string expected = "1234";
            string actual;
            actual = target.FindKthPermutation(n, k);
            Assert.AreEqual(expected, actual);


            k = 2;
            expected = "1243";
            actual = target.FindKthPermutation(n, k);
            Assert.AreEqual(expected, actual);

            //k = 12;
            //expected = "2431";
            //actual = target.FindKthPermutation(n, k);
            //Assert.AreEqual(expected, actual);

            k = 22;
            expected = "4231";
            actual = target.FindKthPermutation(n, k);
            Assert.AreEqual(expected, actual);

            /*
             * 4, 1 "" "1234"     4, 2 "" "1243"     4, 3 "" "1324"     4, 4 "" "1342"     4, 5 "" "1423"     4, 6 "" "1432"     4, 7 "" "2134"     4, 8 "" "2143"     4, 9 "" "2314"     4, 10 "" "2341"     4, 11 "" "2413"     4, 12 "" "2431"     4, 13 "" "3124"     4, 14 "" "3142"     4, 15 "" "3214"     4, 16 "" "3241"     4, 17 "" "3412"     4, 18 "" "3421"     4, 19 "" "4123"     4, 20 "" "4132"     4, 21 "" "4213"     4, 22 "" "4231"     4, 23 "" "4312"     4, 24 "" "4321 
             */
        }

        /// <summary>
        ///A test for KthPermutation
        ///</summary>
        [TestMethod()]
        public void KthPermutationTest()
        {
            _052_KthPermutation target = new _052_KthPermutation(); // TODO: Initialize to an appropriate value
            string s = "1234";
            int k = 12; // TODO: Initialize to an appropriate value
            string expected = "2431"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.KthPermutation(s, k);
            Assert.AreEqual(expected, actual);
            
        }
    }
}
