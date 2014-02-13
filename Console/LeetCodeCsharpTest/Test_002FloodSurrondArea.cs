using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeCSharp;
using System.Collections.Generic;

namespace LeetCodeCsharpTest
{
    [TestClass]
    public class Test_002FloodSurrondArea
    {
        [TestMethod]
        public void TestFloodArea()
        {
            _002_FloodSurroundArea target = new _002_FloodSurroundArea();

            /*["OOOOOO","OXXXXO","OXOOXO","OXOOXO","OXXXXO","OOOOOO"]*/
            List<List<FloodNode>> input = new List<List<FloodNode>>();

            for (int j = 0; j < 6; j++)
            {
                List<FloodNode> row1 = new List<FloodNode>();
                for (int i = 0; i < 6; i++)
                {
                    row1.Add(new FloodNode() { value = 'o' });
                }
                input.Add(row1);
            }
             
            input[1][1].value = 'x';
            input[1][2].value = 'x';
            input[1][3].value = 'x';
            input[1][4].value = 'x';

            input[2][1].value = 'x';
            input[2][4].value = 'x';

            input[3][1].value = 'x';
            input[3][4].value = 'x';

            input[4][1].value = 'x';
            input[4][2].value = 'x';
            input[4][3].value = 'x';
            input[4][4].value = 'x';


            List<List<FloodNode>> actual = target.FloodBitMap(input);


        }
    }
}
