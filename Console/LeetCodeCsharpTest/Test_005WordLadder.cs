using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeCSharp;
using System.Collections.Generic;

namespace LeetCodeCsharpTest
{
    [TestClass]
    public class Test_005WordLadder
    {
        [TestMethod]
        public void TestWordLadder()
        {
            _005_WordLadder target = new _005_WordLadder();
            string[] dict = new string[] { "hot", "dot", "dog", "lot", "log" };
            string start = "hit";
            string end = "cog";
            int actual = target.FindWordLadderLength(dict, start, end);
            Assert.AreEqual(5, actual);

            dict = new string[] { "gasket", "hearer", "linker", "bitter", "dissed", "filled", "donner", "fences", "cronus", "spaced", "halsey", "tracey", "earwax", "glider", "shoved", "rather", "tender", "copter", "swoons", "croons", "hazing", "crying", "wanted", "basket", "feller", "posses", "snails", "spaces", "series", "socked", "singly", "douses", "pivots", "brooms", "atoned", "barred", "weirds", "wildly", "quited", "culled", "hoofed", "thorax", "penned", "backed", "smalls", "dorset", "stores", "massey", "soaked", "gutted", "slings", "corvus", "lewder", "soared", "meagan", "bathes", "debase", "killed", "passel", "rutted", "leaves", "caller", "sayers", "balled", "fluent", "quaver", "belong", "lifted", "stints", "callow", "pummel", "fluked", "ribald", "tanker", "blocks", "braver", "licked", "pupped", "upjohn", "seller", "warmed", "skited", "jotted", "tushes", "sacked", "darker", "lassos", "sporty", "hushed", "gender", "gashed", "insole", "nasser", "yankee", "barked", "bastes", "header", "photon", "fluxes", "harped", "wasted", "tarter", "crusoe", "gaping", "netted", "hatred", "cursed", "dauber", "tanner", "sicken", "peered", "leaven", "ranter", "dicier", "chiles", "nearer", "pucked", "hinged", "basked", "loaner", "staler", "brayed", "scaled" };
            start = "soared";
            end = "gasket";
            actual = target.FindWordLadderLength(dict, start, end);
            Assert.AreEqual(8, actual);
        }

        [TestMethod]
        public void TestWordLadderII()
        {
            _005_WordLadder target = new _005_WordLadder();
            string[] dict = new string[] { "hot", "dot", "dog", "lot", "log" };
            string start = "hit";
            string end = "cog";
            List<List<string>> actual = target.FindWordLadderII(dict, start, end);
            Assert.AreEqual(2, actual.Count);

            Assert.AreEqual("hit", actual[0][0]);
            Assert.AreEqual("hot", actual[0][1]);
            Assert.AreEqual("dot", actual[0][2]);
            Assert.AreEqual("dog", actual[0][3]);
            Assert.AreEqual("cog", actual[0][4]);

            Assert.AreEqual("hit", actual[1][0]);
            Assert.AreEqual("hot", actual[1][1]);
            Assert.AreEqual("lot", actual[1][2]);
            Assert.AreEqual("log", actual[1][3]);
            Assert.AreEqual("cog", actual[1][4]);

        }
    }
}
