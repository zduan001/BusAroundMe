using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SinglePlayer;
using HardSingleProblem;

namespace HackerRankTest
{
    [TestClass]
    public class TestPlayers
    {
        [TestMethod]
        public void TestMethodBotCleanStochastic()
        {
            BotCleanStochastic target = new BotCleanStochastic();
            int posX = 0;
            int posY = 0;
            string[] input = new string[] { "b----", "-----", "-----", "-d---", "-----" };
            target.nextMove(posX, posY, input);
        }

        [TestMethod]
        public void TestBotCleanPartiallyObservable()
        {
            BotCleanPartiallyObservable target = new BotCleanPartiallyObservable();
            int posX = 0;
            int posY = 1;
            string[] input = new string[] { "-----", "-d---", "-----", "-----", "-----" };
            target.next_move(posX, posY, input);
        }
    }
}
