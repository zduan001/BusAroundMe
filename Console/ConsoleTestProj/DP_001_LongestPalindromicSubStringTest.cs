using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for DP_001_LongestPalindromicSubStringTest and is intended
    ///to contain all DP_001_LongestPalindromicSubStringTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DP_001_LongestPalindromicSubStringTest
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
        ///A test for FindLongestPalindromicSubString
        ///</summary>
        [TestMethod()]
        public void FindLongestPalindromicSubStringTest()
        {
            DP_001_LongestPalindromicSubString target = new DP_001_LongestPalindromicSubString();
            string input = "bananas";
            string expected = "anana";
            string actual = target.FindLongestPalindromicSubString(input);
            Assert.AreEqual(expected, actual);


            input = "madam";
            expected = "madam";
            actual = target.FindLongestPalindromicSubString(input);
            Assert.AreEqual(expected, actual);

            input = "civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth";
            expected = "ranynar";
            actual = target.FindLongestPalindromicSubString(input);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for FindLongestPalindromicSubStringDP
        ///</summary>
        [TestMethod()]
        public void FindLongestPalindromicSubStringDPTest()
        {
            DP_001_LongestPalindromicSubString target = new DP_001_LongestPalindromicSubString();
            string input = "bananas";
            string expected = "anana";
            string actual = target.FindLongestPalindromicSubStringDP(input);
            Assert.AreEqual(expected, actual);

            input = "madam";
            expected = "madam";
            actual = target.FindLongestPalindromicSubStringDP(input);
            Assert.AreEqual(expected, actual);

            input = "civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth";
            expected = "ranynar";
            actual = target.FindLongestPalindromicSubStringDP(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
