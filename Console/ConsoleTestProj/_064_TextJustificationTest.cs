using console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{


    /// <summary>
    ///This is a test class for _064_TextJustificationTest and is intended
    ///to contain all _064_TextJustificationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _064_TextJustificationTest
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
        ///A test for TextJustification
        ///</summary>
        [TestMethod()]
        public void TextJustificationTest()
        {
            _064_TextJustification target = new _064_TextJustification(); // TODO: Initialize to an appropriate value
            List<string> words = new List<string>() { "This", "is", "an", "example", "of", "text", "justification." };
            int l = 16;
            List<string> actual = target.TextJustification(words, l);
            for (int i = 0; i < actual.Count - 1; i++)
            {
                Assert.AreEqual(l, actual[i].Length, "line " + i.ToString() + " should be same.");
            }


            words = new List<string>() { "Fourscore", "and", "seven", "years", "ago", "our", "fathers", "brought", "forth", "on", "this", "continent", "a", "new", "nation,", "conceived", "in", "liberty", "and", "dedicated", "to", "the", "proposition", "that", "all", "men", "are", "created", "equal.", "Now", "we", "are", "engaged", "in", "a", "great", "civil", "war,", "testing", "whether", "that", "nation", "or", "any", "nation", "so", "conceived", "and", "so", "dedicated", "can", "long", "endure.", "We", "are", "met", "on", "a", "great", "battlefield", "of", "that", "war.", "We", "have", "come", "to", "dedicate", "a", "portion", "of", "that", "field", "as", "a", "final", "resting-place", "for", "those", "who", "here", "gave", "their", "lives", "that", "that", "nation", "might", "live.", "It", "is", "altogether", "fitting", "and", "proper", "that", "we", "should", "do", "this.", "But", "in", "a", "larger", "sense,", "we", "cannot", "dedicate,", "we", "cannot", "consecrate,", "we", "cannot", "hallow", "this", "ground.", "The", "brave", "men,", "living", "and", "dead", "who", "struggled", "here", "have", "consecrated", "it", "far", "above", "our", "poor", "power", "to", "add", "or", "detract.", "The", "world", "will", "little", "note", "nor", "long", "remember", "what", "we", "say", "here,", "but", "it", "can", "never", "forget", "what", "they", "did", "here.", "It", "is", "for", "us", "the", "living", "rather", "to", "be", "dedicated", "here", "to", "the", "unfinished", "work", "which", "they", "who", "fought", "here", "have", "thus", "far", "so", "nobly", "advanced.", "It", "is", "rather", "for", "us", "to", "be", "here", "dedicated", "to", "the", "great", "task", "remaining", "before", "us--that", "from", "these", "honored", "dead", "we", "take", "increased", "devotion", "to", "that", "cause", "for", "which", "they", "gave", "the", "last", "full", "measure", "of", "devotion--that", "we", "here", "highly", "resolve", "that", "these", "dead", "shall", "not", "have", "died", "in", "vain,", "that", "this", "nation", "under", "God", "shall", "have", "a", "new", "birth", "of", "freedom,", "and", "that", "government", "of", "the", "people,", "by", "the", "people,", "for", "the", "people", "shall", "not", "perish", "from", "the", "earth." };
            List<string> expected = new List<string>() { "Fourscore  and seven years ago our fathers brought forth on this continent a new", "nation,  conceived  in liberty and dedicated to the proposition that all men are", "created  equal.  Now  we  are engaged in a great civil war, testing whether that", "nation  or  any nation so conceived and so dedicated can long endure. We are met", "on  a  great battlefield of that war. We have come to dedicate a portion of that", "field  as  a  final  resting-place for those who here gave their lives that that", "nation  might  live. It is altogether fitting and proper that we should do this.", "But  in  a  larger  sense,  we  cannot dedicate, we cannot consecrate, we cannot", "hallow  this  ground.  The  brave  men,  living and dead who struggled here have", "consecrated it far above our poor power to add or detract. The world will little", "note  nor  long remember what we say here, but it can never forget what they did", "here. It is for us the living rather to be dedicated here to the unfinished work", "which  they who fought here have thus far so nobly advanced. It is rather for us", "to  be  here  dedicated  to  the great task remaining before us--that from these", "honored  dead  we  take increased devotion to that cause for which they gave the", "last full measure of devotion--that we here highly resolve that these dead shall", "not  have  died  in  vain,  that this nation under God shall have a new birth of", "freedom,  and that government of the people, by the people, for the people shall", "not perish from the earth." };
            l = 80;
            actual = target.TextJustification(words, l);
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
