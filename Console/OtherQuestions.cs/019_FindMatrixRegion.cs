using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _019_FindMatrixRegion
    {
        public int CountRegions(int[,] input, int startRow, int endRow)
        {
            if (startRow > endRow) return 0;
            if (startRow == endRow)
            {
                return GetRegionsInOneRow(input, startRow);
            }

            int midRow = startRow + (endRow - startRow) / 2;
            int upperRegion = CountRegions(input, startRow, midRow);
            int lowerRegion = CountRegions(input, midRow + 1, endRow);
            int connections = 0;
            if (midRow + 1 < input.GetLength(0))
            {
                connections = CountConnections(input, midRow, midRow + 1, startRow, endRow);
            }
            return upperRegion + lowerRegion - connections;
        }

        private int GetRegionsInOneRow(int[,] input, int rowIndex)
        {
            int regions = 0;
            bool isOne = false;
            for (int i = 0; i < input.GetLength(1); i++)
            {
                if (input[rowIndex, i] == 1)
                {
                    if (!isOne)
                    {
                        isOne = true;
                        regions++;
                    }
                }
                else // must be zero, can do a assert here.
                {
                    isOne = false;
                }
            }
            return regions;
        }

        private int CountConnections(int[,] input, int firstRow, int secondRow, int topRow, int bottomRow )
        {
            if (firstRow < topRow || secondRow > bottomRow) return 0;

            int groupId = 0;
            int[,] tracker = new int[input.GetLength(0), input.GetLength(1)];

            for (int i = 0; i < input.GetLength(1);i++ )
            {
                if (input[firstRow, i] == 1 && input[secondRow, i] == 1 && tracker[firstRow, i] == 0)
                {
                    groupId++;
                    Connect(input, firstRow, i, topRow, firstRow, tracker, groupId);
                    Connect(input, secondRow, i, secondRow, bottomRow, tracker, groupId);
                }
            }

            HashSet<KeyValuePair<int, int>> t = new HashSet<KeyValuePair<int, int>>();
            int connections = 0;

            for (int i = 0; i < input.GetLength(1); i++)
            {
                if (input[firstRow, i] == 1 && input[secondRow, i] == 1)
                {
                    if (!t.Contains(new KeyValuePair<int,int>(tracker[firstRow,i],tracker[secondRow,i])))
                    {
                        t.Add(new KeyValuePair<int,int>(tracker[firstRow, i], tracker[secondRow, i]));
                        connections++;
                    }
                }
            }

            return connections;
        }

        private void Connect(int[,] input, int i, int j, int topRow, int bottomRow, int[,] tracker, int k)
        {
            if (input[i, j] == 0 || tracker[i, j] != 0)
            {
                return;
            }
            else
            {
                tracker[i,j] = k;
                if (i - 1 >= topRow) Connect(input, i - 1, j, topRow, bottomRow, tracker, k);
                if (i + 1 <= bottomRow) Connect(input, i + 1, j, topRow, bottomRow, tracker, k);
                if (j - 1 >= 0) Connect(input, i, j - 1, topRow, bottomRow, tracker, k);
                if (j + 1 <= input.GetLength(1)) Connect(input, i, j + 1, topRow, bottomRow, tracker, k);
            }
            return;

        }
    }
}
