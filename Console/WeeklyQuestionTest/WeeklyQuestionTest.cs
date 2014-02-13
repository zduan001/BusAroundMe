using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeeklyQuestions;
using System.Collections.Generic;
using BaseClass;

namespace WeeklyQuestionTest
{
    [TestClass]
    public class WeeklyQuestionTest
    {
        [TestMethod]
        public void TestQuestion1()
        {
            Week1 target = new Week1();
            LogEntry e1 = new LogEntry() { Member1 = 0, Member2 = 1, TimeStamp = 0 };
            LogEntry e2 = new LogEntry() { Member1 = 3, Member2 = 4, TimeStamp = 1 };
            LogEntry e3 = new LogEntry() { Member1 = 1, Member2 = 4, TimeStamp = 2 };
            LogEntry e4 = new LogEntry() { Member1 = 2, Member2 = 3, TimeStamp = 3 };
            LogEntry e5 = new LogEntry() { Member1 = 0, Member2 = 5, TimeStamp = 4 };
            LogEntry e6 = new LogEntry() { Member1 = 0, Member2 = 4, TimeStamp = 5 };

            List<LogEntry> l1 = new List<LogEntry> { e1, e2, e3, e4, e5, e6 };
            int actual = target.Question1(l1, 6);
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestQuestion1_II()
        {
            Week1 target = new Week1();
            LogEntry e1 = new LogEntry() { Member1 = 0, Member2 = 1, TimeStamp = 0 };
            LogEntry e2 = new LogEntry() { Member1 = 3, Member2 = 4, TimeStamp = 1 };
            LogEntry e3 = new LogEntry() { Member1 = 1, Member2 = 4, TimeStamp = 2 };
            LogEntry e4 = new LogEntry() { Member1 = 2, Member2 = 3, TimeStamp = 3 };
            LogEntry e6 = new LogEntry() { Member1 = 0, Member2 = 4, TimeStamp = 4 };
            LogEntry e5 = new LogEntry() { Member1 = 0, Member2 = 5, TimeStamp = 5 };

            List<LogEntry> l1 = new List<LogEntry> { e1, e2, e3, e4, e5, e6 };
            int actual = target.Question1(l1, 6);
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void TestQuestion2_II()
        {
            Week1 target = new Week1();
            LogEntry e1 = new LogEntry() { Member1 = 0, Member2 = 1, TimeStamp = 0 };
            LogEntry e2 = new LogEntry() { Member1 = 3, Member2 = 4, TimeStamp = 1 };
            LogEntry e3 = new LogEntry() { Member1 = 1, Member2 = 4, TimeStamp = 2 };
            LogEntry e4 = new LogEntry() { Member1 = 2, Member2 = 3, TimeStamp = 3 };
            LogEntry e6 = new LogEntry() { Member1 = 0, Member2 = 4, TimeStamp = 4 };
            //LogEntry e5 = new LogEntry() { Member1 = 0, Member2 = 5, TimeStamp = 5 };

            List<LogEntry> l1 = new List<LogEntry> { e1, e2, e3, e4, e6 };
            target.Question2(l1, 5);
            int actual;
            actual = target.FinxMax(0);
            Assert.AreEqual(4, actual);

            actual = target.FinxMax(1);
            Assert.AreEqual(4, actual);

            actual = target.FinxMax(2);
            Assert.AreEqual(4, actual);

            actual = target.FinxMax(3);
            Assert.AreEqual(4, actual);

            actual = target.FinxMax(4);
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void Test_Week2_Q_5_CloineLinkedList()
        {
            Node n1 = new Node { item = "1" };
            Node n2 = new Node { item = "2" };
            Node n3 = new Node { item = "3" };
            Node n4 = new Node { item = "4" };
            Node n5 = new Node { item = "5" };

            n1.next = n2;
            n1.random = n3;

            n2.next = n3;
            n2.random = n1;

            n3.next = n4;
            n3.random = n3;

            n4.next = n5;
            n4.random = n2;

            n5.next = null;
            n5.random = n1;

            Week_2 target = new Week_2();
            Node actual = target.Q_5_CloineLinkedList(n1);

        }


        [TestMethod]
        public void Test_AlgII_Week1_VerifyBiparties()
        {
            AlgII_Week1 target = new AlgII_Week1();
            bool actual = target.VerifyBiparties(CreateAGraphII());
            Assert.IsTrue(actual);

            actual = target.VerifyBiparties(CreateAGraphI());
            Assert.IsFalse(actual);
        }

        private static GraphAdjacence<char> CreateAGraphII()
        {
            GraphNode<char> n0 = new GraphNode<char>() { Key = '0' };
            GraphNode<char> n1 = new GraphNode<char>() { Key = '1' };
            GraphNode<char> n2 = new GraphNode<char>() { Key = '2' };
            GraphNode<char> n3 = new GraphNode<char>() { Key = '3' };
            GraphNode<char> n4 = new GraphNode<char>() { Key = '4' };
            GraphNode<char> n5 = new GraphNode<char>() { Key = '5' };
            GraphNode<char> n6 = new GraphNode<char>() { Key = '6' };


            n0.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(n1,1),
                new KeyValuePair<GraphNode<char>, int>(n2,1),
                new KeyValuePair<GraphNode<char>, int>(n2,5),
                new KeyValuePair<GraphNode<char>, int>(n2,6)
            };

            n1.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(n0,2),
                new KeyValuePair<GraphNode<char>, int>(n3,1)
            };

            n2.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(n0,3),
                new KeyValuePair<GraphNode<char>, int>(n3,9),
                new KeyValuePair<GraphNode<char>, int>(n4,2)
            };

            n3.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(n1,4),
                new KeyValuePair<GraphNode<char>, int>(n2,4)
            };

            n4.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(n2,7),
                new KeyValuePair<GraphNode<char>, int>(n5,6),
                new KeyValuePair<GraphNode<char>, int>(n6,6)
            };

            n5.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(n0,4),
                new KeyValuePair<GraphNode<char>, int>(n4,4)
            };

            n6.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(n0,4),
                new KeyValuePair<GraphNode<char>, int>(n4,4)
            };

            List<GraphNode<char>> input = new List<GraphNode<char>>()
            {
                n0,n1,n2,n3,n4,n5,n6
            };
            return new GraphAdjacence<char>() { Nodes = input };
        }

        private static GraphAdjacence<char> CreateAGraphI()
        {
            GraphAdjacence<char> res = CreateAGraphII();
            res.Nodes[1].Neiborghs.Add(new KeyValuePair<GraphNode<char>, int>(res.Nodes[2], 1));
            return res;
        }
    }
}
