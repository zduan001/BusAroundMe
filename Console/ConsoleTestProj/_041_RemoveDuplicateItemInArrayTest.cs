using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _041_RemoveDuplicateItemInArrayTest and is intended
    ///to contain all _041_RemoveDuplicateItemInArrayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _041_RemoveDuplicateItemInArrayTest
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
        ///A test for RemoveDup
        ///</summary>
        [TestMethod()]
        public void RemoveDupTest()
        {
            _041_RemoveDuplicateItemInArray target = new _041_RemoveDuplicateItemInArray(); // TODO: Initialize to an appropriate value
            int[] input = new int[] {1,2,3,3,3,3,3,4};
            int[] expected = new int[] { 1, 2, 3, 4 };
            int[] actual;
            actual = target.RemoveDup(input);

            //Assert.AreEqual(expected.Length, actual.Length, "lenght should be same");
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], "element " + i.ToString() + " should be same");
            }
            for (int i = expected.Length; i < actual.Length; i++)
            {
                Assert.AreEqual(int.MinValue, actual[i], "these element should be minvalues");
            }

            input = new int[] { 1, 3, 3, 3, 3, 3, 3, 3 };
            expected = new int[] { 1, 3 };
            actual = target.RemoveDup(input);

            //Assert.AreEqual(expected.Length, actual.Length, "lenght should be same");
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], "element " + i.ToString() + " should be same");
            }
            for (int i = expected.Length; i < actual.Length; i++)
            {
                Assert.AreEqual(int.MinValue, actual[i], "these element should be minvalues");
            }

            input = new int[] { 3, 3, 3, 3, 3, 3, 3, 3 };
            expected = new int[] { 3 };
            actual = target.RemoveDup(input);

            //Assert.AreEqual(expected.Length, actual.Length, "lenght should be same");
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], "element " + i.ToString() + " should be same");
            }
            for (int i = expected.Length; i < actual.Length; i++)
            {
                Assert.AreEqual(int.MinValue, actual[i], "these element should be minvalues");
            }


            input = new int[] { 3, 3, 3, 3, 3, 3, 3, 5 };
            expected = new int[] { 3,5 };
            actual = target.RemoveDup(input);

            //Assert.AreEqual(expected.Length, actual.Length, "lenght should be same");
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], "element " + i.ToString() + " should be same");
            }
            for (int i = expected.Length; i < actual.Length; i++)
            {
                Assert.AreEqual(int.MinValue, actual[i], "these element should be minvalues");
            }

            input = new int[] { 1, 1, 1, 2, 3, 3, 3, 5 };
            expected = new int[] { 1,2,3, 5 };
            actual = target.RemoveDup(input);

            //Assert.AreEqual(expected.Length, actual.Length, "lenght should be same");
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], "element " + i.ToString() + " should be same");
            }
            for (int i = expected.Length; i < actual.Length; i++)
            {
                Assert.AreEqual(int.MinValue, actual[i], "these element should be minvalues");
            }
        }

        /// <summary>
        ///A test for RemoveDupAllowDup2
        ///</summary>
        [TestMethod()]
        public void RemoveDupAllowDup2Test()
        {
            _041_RemoveDuplicateItemInArray target = new _041_RemoveDuplicateItemInArray(); // TODO: Initialize to an appropriate value
            int[] input = new int[] { 1, 2, 3, 3, 3, 3, 3, 4 };
            int[] expected = new int[] { 1, 2, 3,3, 4 };
            int[] actual;
            actual = target.RemoveDupAllowDup2(input);

            //Assert.AreEqual(expected.Length, actual.Length, "lenght should be same");
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], "element " + i.ToString() + " should be same");
            }
            for (int i = expected.Length; i < actual.Length; i++)
            {
                Assert.AreEqual(int.MinValue, actual[i], "these element should be minvalues");
            }

            input = new int[] { 1, 3, 3, 3, 3, 3, 3, 3 };
            expected = new int[] { 1, 3,3 };
            actual = target.RemoveDupAllowDup2(input);

            //Assert.AreEqual(expected.Length, actual.Length, "lenght should be same");
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], "element " + i.ToString() + " should be same");
            }
            for (int i = expected.Length; i < actual.Length; i++)
            {
                Assert.AreEqual(int.MinValue, actual[i], "these element should be minvalues");
            }

            input = new int[] { 3, 3, 3, 3, 3, 3, 3, 3 };
            expected = new int[] { 3,3};
            actual = target.RemoveDupAllowDup2(input);

            //Assert.AreEqual(expected.Length, actual.Length, "lenght should be same");
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], "element " + i.ToString() + " should be same");
            }
            for (int i = expected.Length; i < actual.Length; i++)
            {
                Assert.AreEqual(int.MinValue, actual[i], "these element should be minvalues");
            }


            input = new int[] { 3, 3, 3, 3, 3, 3, 3, 5 };
            expected = new int[] { 3,3, 5 };
            actual = target.RemoveDupAllowDup2(input);

            //Assert.AreEqual(expected.Length, actual.Length, "lenght should be same");
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], "element " + i.ToString() + " should be same");
            }
            for (int i = expected.Length; i < actual.Length; i++)
            {
                Assert.AreEqual(int.MinValue, actual[i], "these element should be minvalues");
            }


        }

    }
}
