using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseClass;
using System.Collections.Generic;
using BackTracking;

namespace AlgTest
{
    [TestClass]
    public class BackTrackingTest
    {
        [TestMethod]
        public void TestHamiltonianCycle()
        {
            HamiltonianCycle target = new HamiltonianCycle();
            GraphAdjacence<char> input = CreatedGraphIII();
            bool actual = target.FindHamiltonCycle<char>(input);
            Assert.IsTrue(actual);

            input = CreatedGraphI();
            actual = target.FindHamiltonCycle<char>(input);
            Assert.IsTrue(actual);

            input = CreatedGraphII();
            actual = target.FindHamiltonCycle<char>(input);
            Assert.IsFalse(actual);
        }

        private static GraphAdjacence<char> CreatedGraphIII()
        {
            GraphNode<char> a = new GraphNode<char>() { Key = 'a' };
            GraphNode<char> b = new GraphNode<char>() { Key = 'b' };
            GraphNode<char> c = new GraphNode<char>() { Key = 'c' };
            GraphNode<char> d = new GraphNode<char>() { Key = 'd' };
            GraphNode<char> e = new GraphNode<char>() { Key = 'e' };
            GraphNode<char> f = new GraphNode<char>() { Key = 'f' };

            a.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(b,5),
                new KeyValuePair<GraphNode<char>, int>(d,4),
                new KeyValuePair<GraphNode<char>, int>(c,6)
            };

            b.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(a,5),
                new KeyValuePair<GraphNode<char>, int>(d,2),
                new KeyValuePair<GraphNode<char>, int>(c,1)
            };

            c.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(a,6),
                new KeyValuePair<GraphNode<char>, int>(b,1),
                new KeyValuePair<GraphNode<char>, int>(d,2),
                new KeyValuePair<GraphNode<char>, int>(e,5),
                new KeyValuePair<GraphNode<char>, int>(f,3)
            };

            d.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(a,4),
                new KeyValuePair<GraphNode<char>, int>(b,2),
                new KeyValuePair<GraphNode<char>, int>(c,2),
                new KeyValuePair<GraphNode<char>, int>(f,4)
            };

            e.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(c,5),
                new KeyValuePair<GraphNode<char>, int>(f,4)
            };

            f.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(e,4),
                new KeyValuePair<GraphNode<char>, int>(c,3),
                new KeyValuePair<GraphNode<char>, int>(d,4)
            };

            List<GraphNode<char>> input = new List<GraphNode<char>>()
            {
                a, b, c, d, e, f
            };
            return new GraphAdjacence<char>() { Nodes = input };
        }

        private static GraphAdjacence<char> CreatedGraphI()
        {
            GraphNode<char> a = new GraphNode<char>() { Key = 'a' };
            GraphNode<char> b = new GraphNode<char>() { Key = 'b' };
            GraphNode<char> c = new GraphNode<char>() { Key = 'c' };
            GraphNode<char> d = new GraphNode<char>() { Key = 'd' };
            GraphNode<char> e = new GraphNode<char>() { Key = 'e' };
            GraphNode<char> f = new GraphNode<char>() { Key = 'f' };

            a.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(b,5),
                new KeyValuePair<GraphNode<char>, int>(c,6)
            };

            b.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(a,5),
                new KeyValuePair<GraphNode<char>, int>(d,2),
                new KeyValuePair<GraphNode<char>, int>(c,1)
            };

            c.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(a,6),
                new KeyValuePair<GraphNode<char>, int>(b,1),
            };

            d.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(b,2),
                new KeyValuePair<GraphNode<char>, int>(f,4)
            };

            e.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(f,4)
            };

            f.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(e,4),
                new KeyValuePair<GraphNode<char>, int>(d,4)
            };

            List<GraphNode<char>> input = new List<GraphNode<char>>()
            {
                a, b, c, d, e, f
            };
            return new GraphAdjacence<char>() { Nodes = input };
        }

        private static GraphAdjacence<char> CreatedGraphII()
        {
            GraphNode<char> a = new GraphNode<char>() { Key = 'a' };
            GraphNode<char> b = new GraphNode<char>() { Key = 'b' };
            GraphNode<char> c = new GraphNode<char>() { Key = 'c' };
            GraphNode<char> d = new GraphNode<char>() { Key = 'd' };
            GraphNode<char> e = new GraphNode<char>() { Key = 'e' };
            GraphNode<char> f = new GraphNode<char>() { Key = 'f' };

            a.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(b,5)
            };

            b.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(a,5),
                new KeyValuePair<GraphNode<char>, int>(d,2),
                new KeyValuePair<GraphNode<char>, int>(c,1)
            };

            c.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(b,1)
            };

            d.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(b,2),
                new KeyValuePair<GraphNode<char>, int>(f,4)
            };

            e.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(f,4)
            };

            f.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(e,4),
                new KeyValuePair<GraphNode<char>, int>(d,4)
            };

            List<GraphNode<char>> input = new List<GraphNode<char>>()
            {
                a, b, c, d, e, f
            };
            return new GraphAdjacence<char>() { Nodes = input };
        }
    }
}
