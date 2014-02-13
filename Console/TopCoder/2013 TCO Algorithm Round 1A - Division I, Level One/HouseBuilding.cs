using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013_TCO_Algorithm_Round_1A___Division_I__Level_One
{
    public class HouseBuilding
    {
        /*http://community.topcoder.com/stat?c=problem_statement&pm=12396&rd=15571
         * Problem Statement 
             Manao is building a new house. He already purchased a rectangular area where he will place the house. The basement of the house should be built on a level ground, so Manao will have to level the entire area. The area is leveled if the difference between the heights of its lowest and highest square meter is at most 1. Manao wants to measure the effort he needs to put into ground leveling. 

            You are given a String[] area. Each character in area denotes the height at the corresponding square meter of Manao's area. Using 1 unit of effort, Manao can change the height of any square meter on his area by 1 up or down. Return the minimum total effort he needs to put to obtain a leveled area.  
  
            Definition 
                 Class: HouseBuilding 
            Method: getMinimum 
            Parameters: String[] 
            Returns: int 
            Method signature: int getMinimum(String[] area) 
            (be sure your method is public) 
  
            Constraints 
            - area will contain between 1 and 50 elements, inclusive. 
            - Each element of area will be between 1 and 50 characters long, inclusive. 
            - All elements of area will be of the same length. 
            - Each element of area will contain digits ('0'-'9') only. 
         */
        public int GetMinimum(string[] area)
        {
            Dictionary<int, int> height = new Dictionary<int, int>();
            for (int i = 0; i < 10; i++)
            {
                height.Add(i, 0);
            }
            int minHeight = int.MaxValue;
            int maxHeight = int.MinValue;
            foreach (string s in area)
            {
                foreach (char c in s)
                {
                    int h = c - '0';
                    height[h]++;
                    if (h < minHeight)
                    {
                        minHeight = h;
                    }
                    if (h > maxHeight)
                    {
                        maxHeight = h;
                    }
                }
            }
            int minCost = int.MaxValue;
            if (maxHeight - minHeight <= 1)
            {
                minCost = 0;
            }
            else
            {
                for (int i = minHeight + 1; i <= maxHeight; i++)
                {
                    int tmp = 0;
                    for (int j = minHeight; j <= maxHeight; j++)
                    {
                        if (j <= i - 1)
                        {
                            tmp += height[j] * Math.Abs((i - 1) - j);
                        }
                        else
                        {
                            tmp += height[j] * Math.Abs(j - i);
                        }

                    }
                    if (tmp < minCost)
                    {
                        minCost = tmp;
                    }
                }
            }

            return minCost;
        }
    }
}
