using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CareerCup150;

namespace CareerCupTest
{
    [TestClass]
    public class UnitTest_Chapter20
    {
        [TestMethod]
        public void TestQuestion20_12 ()
        {
            Question20_12 target = new Question20_12();
            int[,] input = { { -1, -1, -1, -1, -1 }, { -1, -1, 2, 2, -1 }, { -1, -1, 2, 2, -1 }, { -1, -1, 2, 2, -1 }, { -1, -1, -1, -1, -1 } };
            int actual = target.FindMax(input, 5);
            Assert.AreEqual(12, actual);
        }

        [TestMethod]
        public void TestQuestion20_11()
        {
            _20_11_blackBoarder target = new _20_11_blackBoarder();
            char[,] input = { {'w','b','b','b'},{'w','b','b','w'},{'w','b','b','w'},{'b','b','b','w'} };
            int actual = target.FindBlackSubMatrix(input, 4);
        }
    }
}
