using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chapter22;
using BaseClass;
using System.Collections.Generic;

namespace CLRSTest
{
    [TestClass]
    public class Chapter22
    {
        [TestMethod]
        public void TestDFSSerach()
        {
            DFS target = new DFS();
            GraphAdjacence<int> input = CreateAGraph();

            target.DFSSearch(input);
            Assert.AreEqual(1, input.Nodes[0].DiscoverTime);
            Assert.AreEqual(8, input.Nodes[0].FinishTime);
        }

        [TestMethod]
        public void TestTopLogicSort()
        {
            TopLogicSort target = new TopLogicSort();
            GraphAdjacence<int> input = CreateAGraph();
            LinkListNode<GraphNode<int>> actual = target.Sort(input);
        }

        [TestMethod]
        public void TestTranspose()
        {
            TransposeGraph target = new TransposeGraph();
            GraphAdjacence<int> input = CreateAGraph();
            target.CreateTranspose(input);
            Assert.AreEqual(null, input.Nodes[0].TransposeNeiborghs); // u
            Assert.AreEqual(2, input.Nodes[1].TransposeNeiborghs.Count); //v
            Assert.AreEqual(null, input.Nodes[2].TransposeNeiborghs); //w
            Assert.AreEqual(2, input.Nodes[3].TransposeNeiborghs.Count); //x
            Assert.AreEqual(2, input.Nodes[4].TransposeNeiborghs.Count); //y
            Assert.AreEqual(2, input.Nodes[5].TransposeNeiborghs.Count); //z

        }

        [TestMethod]
        public void TestFindSCC()
        {
            FindStrongConnected target = new FindStrongConnected();
            GraphAdjacence<int> input = CreateAGraph();
            target.FindSCC(input);

            Assert.AreEqual(2, input.Nodes[0].Key);
            Assert.AreEqual(0, input.Nodes[0].CC_Id);

            Assert.AreEqual(5, input.Nodes[1].Key);
            Assert.AreEqual(1, input.Nodes[1].CC_Id);

            Assert.AreEqual(0, input.Nodes[2].Key);
            Assert.AreEqual(2, input.Nodes[2].CC_Id);

            Assert.AreEqual(1, input.Nodes[3].Key);
            Assert.AreEqual(3, input.Nodes[3].CC_Id);

            Assert.AreEqual(4, input.Nodes[4].Key);
            Assert.AreEqual(3, input.Nodes[4].CC_Id);

            Assert.AreEqual(3, input.Nodes[5].Key);
            Assert.AreEqual(3, input.Nodes[5].CC_Id);
        }

        [TestMethod]
        public void TestDijkstra()
        {
            Dijkstra target = new Dijkstra();
            GraphAdjacence<char> input = CreateAGraphII();
            Dictionary<GraphNode<char>, int> actual  = target.FindShortestPart(input, input.Nodes[0]);

            foreach (GraphNode<char> n in input.Nodes)
            {
                switch (n.Key)
                {
                    case 's':
                        Assert.AreEqual(0, actual[n]);
                        break;
                    case 't':
                        Assert.AreEqual(8, actual[n]);
                        break;
                    case 'y':
                        Assert.AreEqual(5, actual[n]);
                        break;
                    case 'x':
                        Assert.AreEqual(9, actual[n]);
                        break;
                    case 'z':
                        Assert.AreEqual(7, actual[n]);
                        break;
                }
            }
        }

        [TestMethod]
        public void TestPrims()
        {
            PrimsMethod target = new PrimsMethod();
            GraphAdjacence<char> input = CreatedGraphIII();
            Dictionary<GraphNode<char>, GraphNode<char>> actual = target.Prims(input);

            Assert.AreEqual(null, actual[input.Nodes[0]]);
            Assert.AreEqual(input.Nodes[0], actual[input.Nodes[3]]);
            Assert.AreEqual(input.Nodes[3], actual[input.Nodes[1]]);
            Assert.AreEqual(input.Nodes[1], actual[input.Nodes[2]]);
            Assert.AreEqual(input.Nodes[2], actual[input.Nodes[5]]);
            Assert.AreEqual(input.Nodes[5], actual[input.Nodes[4]]);
        }

        [TestMethod]
        public void TestKruskal()
        {
            KruskalMinSpanningTree target = new KruskalMinSpanningTree();
            GraphAdjacence<char> input = CreatedGraphIV();
            List<GraphEdge<GraphNode<char>>> actual = target.FindMinSpanningTree(input);
            Assert.AreEqual(8, actual.Count);
            Assert.IsTrue( actual.Exists(x => x.Weight == 1));
            Assert.IsTrue( actual.Exists(x => x.Weight == 2));
            Assert.IsTrue( actual.Exists(x => x.Weight == 4));
            Assert.IsTrue( actual.Exists(x => x.Weight == 7));
            Assert.IsTrue( actual.Exists(x => x.Weight == 8));
            Assert.IsTrue( actual.Exists(x => x.Weight == 9));
        }

        [TestMethod]
        public void TestBellManFord()
        {
            BellmanFord target = new BellmanFord();
            GraphAdjacence<char> input = GreateGraphV();
            Assert.IsTrue( target.FindShortestDistance(input, input.Nodes[0]));

            Assert.AreEqual(0, input.Nodes[0].CC_Id);
            Assert.AreEqual(2, input.Nodes[1].CC_Id);
            Assert.AreEqual(7, input.Nodes[2].CC_Id);
            Assert.AreEqual(4, input.Nodes[3].CC_Id);
            Assert.AreEqual(-2, input.Nodes[4].CC_Id);
        }

        private static GraphAdjacence<int> CreateAGraph()
        {
            GraphNode<int> u = new GraphNode<int>() { Key = 0 };
            GraphNode<int> v = new GraphNode<int>() { Key = 1 };
            GraphNode<int> w = new GraphNode<int>() { Key = 2 };
            GraphNode<int> x = new GraphNode<int>() { Key = 3 };
            GraphNode<int> y = new GraphNode<int>() { Key = 4 };
            GraphNode<int> z = new GraphNode<int>() { Key = 5 };

            u.Neiborghs = new List<KeyValuePair<GraphNode<int>, int>>()
            {
                new KeyValuePair<GraphNode<int>, int>(v,1),
                new KeyValuePair<GraphNode<int>, int>(x,1)
            };

            v.Neiborghs = new List<KeyValuePair<GraphNode<int>, int>>()
            {
                new KeyValuePair<GraphNode<int>, int>(y,1)
            };

            x.Neiborghs = new List<KeyValuePair<GraphNode<int>, int>>()
            {
                new KeyValuePair<GraphNode<int>, int>(v,1)
            };

            y.Neiborghs = new List<KeyValuePair<GraphNode<int>, int>>()
            {
                new KeyValuePair<GraphNode<int>, int>(x,1),
            };

            w.Neiborghs = new List<KeyValuePair<GraphNode<int>, int>>()
            {
                new KeyValuePair<GraphNode<int>, int>(y,1),
                new KeyValuePair<GraphNode<int>, int>(z,1)
            };

            z.Neiborghs = new List<KeyValuePair<GraphNode<int>, int>>()
            {
                new KeyValuePair<GraphNode<int>, int>(z,1),
            };

            List<GraphNode<int>> input = new List<GraphNode<int>>()
            {
                u,v,w,x,y,z
            };
            return new GraphAdjacence<int>() { Nodes = input };
        }

        private static GraphAdjacence<char> CreateAGraphII()
        {
            GraphNode<char> s = new GraphNode<char>() { Key = 's' };
            GraphNode<char> t = new GraphNode<char>() { Key = 't' };
            GraphNode<char> y = new GraphNode<char>() { Key = 'y' };
            GraphNode<char> x = new GraphNode<char>() { Key = 'x' };
            GraphNode<char> z = new GraphNode<char>() { Key = 'z' };
            

            s.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(t,10),
                new KeyValuePair<GraphNode<char>, int>(y,5)
            };

            t.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(y,2),
                new KeyValuePair<GraphNode<char>, int>(x,1)
            };

            y.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(t,3),
                new KeyValuePair<GraphNode<char>, int>(x,9),
                new KeyValuePair<GraphNode<char>, int>(z,2)
            };

            x.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(z,4),
            };

            z.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(s,7),
                new KeyValuePair<GraphNode<char>, int>(x,6)
            };

            List<GraphNode<char>> input = new List<GraphNode<char>>()
            {
                s, t, y, x, z
            };
            return new GraphAdjacence<char>() { Nodes = input };
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

        private static GraphAdjacence<char> CreatedGraphIV()
        {
            GraphNode<char> a = new GraphNode<char>() { Key = 'a' };
            GraphNode<char> b = new GraphNode<char>() { Key = 'b' };
            GraphNode<char> c = new GraphNode<char>() { Key = 'c' };
            GraphNode<char> d = new GraphNode<char>() { Key = 'd' };
            GraphNode<char> e = new GraphNode<char>() { Key = 'e' };
            GraphNode<char> f = new GraphNode<char>() { Key = 'f' };
            GraphNode<char> g = new GraphNode<char>() { Key = 'g' };
            GraphNode<char> h = new GraphNode<char>() { Key = 'h' };
            GraphNode<char> i = new GraphNode<char>() { Key = 'i' };

            a.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(b,4),
                new KeyValuePair<GraphNode<char>, int>(h,8)
            };

            b.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(c,8),
                new KeyValuePair<GraphNode<char>, int>(h,11)
            };

            c.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(d,7),
                new KeyValuePair<GraphNode<char>, int>(i,2)
            };

            d.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(e,9),
                new KeyValuePair<GraphNode<char>, int>(f,14)
            };

            e.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(f,10)
            };

            f.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(g,2)
            };

            g.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(h,1),
                new KeyValuePair<GraphNode<char>, int>(i,6)
            };

            h.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(i,7)
            };


            i.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>();

            List<GraphNode<char>> input = new List<GraphNode<char>>()
            {
                a, b, c, d, e, f, g, h, i
            };
            return new GraphAdjacence<char>() { Nodes = input };
        }

        private static GraphAdjacence<char> GreateGraphV()
        {
            GraphNode<char> s = new GraphNode<char>() { Key = 's' };
            GraphNode<char> t = new GraphNode<char>() { Key = 't' };
            GraphNode<char> y = new GraphNode<char>() { Key = 'y' };
            GraphNode<char> x = new GraphNode<char>() { Key = 'x' };
            GraphNode<char> z = new GraphNode<char>() { Key = 'z' };


            s.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(t,6),
                new KeyValuePair<GraphNode<char>, int>(y,7)
            };

            t.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(y,8),
                new KeyValuePair<GraphNode<char>, int>(x,5),
                new KeyValuePair<GraphNode<char>, int>(z,-4)
            };

            y.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(x,-3),
                new KeyValuePair<GraphNode<char>, int>(z,9)
            };

            x.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(t,-2),
                
            };

            z.Neiborghs = new List<KeyValuePair<GraphNode<char>, int>>()
            {
                new KeyValuePair<GraphNode<char>, int>(s,2),
                new KeyValuePair<GraphNode<char>, int>(x,8)
            };

            List<GraphNode<char>> input = new List<GraphNode<char>>()
            {
                s, t, y, x, z
            };
            return new GraphAdjacence<char>() { Nodes = input };
        }

        private static Graph<char> CreateGraph()
        {
            Graph<char> res = new Graph<char>();
            GraphEdge<char> e1 = new GraphEdge<char>()
            {
                Left = 'a',
                Right = 'b',
                Weight = 4
            };
            GraphEdge<char> e2 = new GraphEdge<char>()
            {
                Left = 'a',
                Right = 'h',
                Weight = 8
            };

            GraphEdge<char> e3 = new GraphEdge<char>()
            {
                Left = 'b',
                Right = 'c',
                Weight = 8
            };

            GraphEdge<char> e4 = new GraphEdge<char>()
            {
                Left = 'h',
                Right = 'i',
                Weight = 7
            };

            GraphEdge<char> e5 = new GraphEdge<char>()
            {
                Left = 'c',
                Right = 'i',
                Weight = 2
            };

            GraphEdge<char> e6 = new GraphEdge<char>()
            {
                Left = 'h',
                Right = 'g',
                Weight = 1
            };

            GraphEdge<char> e7 = new GraphEdge<char>()
            {
                Left = 'g',
                Right = 'i',
                Weight = 6
            };

            GraphEdge<char> e8 = new GraphEdge<char>()
            {
                Left = 'g',
                Right = 'f',
                Weight = 2
            };

            GraphEdge<char> e9 = new GraphEdge<char>()
            {
                Left = 'c',
                Right = 'f',
                Weight = 4
            };

            GraphEdge<char> e10 = new GraphEdge<char>()
            {
                Left = 'c',
                Right = 'd',
                Weight = 7
            };

            GraphEdge<char> e11 = new GraphEdge<char>()
            {
                Left = 'd',
                Right = 'e',
                Weight = 9
            };

            GraphEdge<char> e12 = new GraphEdge<char>()
            {
                Left = 'd',
                Right = 'f',
                Weight = 14
            };

            GraphEdge<char> e13 = new GraphEdge<char>()
            {
                Left = 'f',
                Right = 'e',
                Weight = 10
            };

            res.Edges.Add(e1);
            res.Edges.Add(e2);
            res.Edges.Add(e3);
            res.Edges.Add(e4);
            res.Edges.Add(e5);
            res.Edges.Add(e6);
            res.Edges.Add(e7);
            res.Edges.Add(e8);
            res.Edges.Add(e9);
            res.Edges.Add(e10);
            res.Edges.Add(e11);
            res.Edges.Add(e12);
            res.Edges.Add(e13);
            return res;
        }
    }
}
