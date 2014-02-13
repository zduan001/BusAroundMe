using Console2.G_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for G_033_NewQueueTest and is intended
    ///to contain all G_033_NewQueueTest Unit Tests
    ///</summary>
    [TestClass()]
    public class G_033_NewQueueTest
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
        ///A test for Min
        ///</summary>
        [TestMethod()]
        public void MinTest()
        {
            G_033_NewQueue target = new G_033_NewQueue(); // TODO: Initialize to an appropriate value
            target.Enqueue(40);
            target.Enqueue(9);
            target.Enqueue(10);
            target.Enqueue(10);
            target.Enqueue(7);
            target.Enqueue(3);
            target.Enqueue(10);

            Assert.AreEqual(3, target.Min());

            target.Dnqueue();
            Assert.AreEqual(3, target.Min());


            target.Dnqueue();
            Assert.AreEqual(3, target.Min());

            target.Dnqueue();
            Assert.AreEqual(3, target.Min());

            target.Dnqueue();
            Assert.AreEqual(3, target.Min());

            target.Dnqueue();
            Assert.AreEqual(3, target.Min());
            target.Dnqueue();
            Assert.AreEqual(10, target.Min());

        }
    }
}
