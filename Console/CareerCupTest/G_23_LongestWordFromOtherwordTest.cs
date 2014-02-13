using Console2.G_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CareerCupTest
{
    
    
    /// <summary>
    ///This is a test class for G_23_LongestWordFromOtherwordTest and is intended
    ///to contain all G_23_LongestWordFromOtherwordTest Unit Tests
    ///</summary>
    [TestClass()]
    public class G_23_LongestWordFromOtherwordTest
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
        ///A test for LongestWordFromOtherWord
        ///</summary>
        [TestMethod()]
        public void LongestWordFromOtherWordTest()
        {
            G_023_LongestWordFromOtherword target = new G_023_LongestWordFromOtherword(); // TODO: Initialize to an appropriate value
            StreamReader reader = new StreamReader(@"..\..\..\Console2\G_Code\TextFile1.txt");
            StringBuilder sb = new StringBuilder();
            string sLine = string.Empty;
            while (sLine != null)
            {
                sLine = reader.ReadLine();
                if (sLine != null)
                {
                    sb.Append(' ');
                    sb.Append(sLine);
                }
            }
            reader.Close();

            string[] input = sb.ToString().Split(' ');
            List<string> actual;
            actual = target.LongestWordFromOtherWord(input);
            Assert.AreEqual("abranchiate", actual[0]);
        }
    }
}
