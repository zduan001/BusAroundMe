using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    class G_059_UtilityBill
    {
        /*
         * 假设一家utility bill company， 分段收取utility，写程序实现charge
         * http://www.mitbbs.com/article_t/JobHunting/32249603.html
         */
        // use a interval tree. assume input is a array of ChargeChart. and calcute the min charge.
        // which is the level1*rate1 + (usage-level1)*rate2 + (usage - level1 - leve2) * rate3.... 
        // mincharge should be calcuated at O(n)
        // Sort the array base on the low. 
        // build a balanced tree. max is the max value of all child, 
        // while search for charge rate. use the interval tree to do the search.

        public int CalculateCharge(IntervalTreeNode root, int n)
        {
            IntervalTreeNode tmp = root;
            while (tmp != null && (n < root.charge.low || n > root.charge.high))
            {
                if (tmp.leftNode != null && n < tmp.leftNode.charge.max)
                {
                    tmp = tmp.leftNode;
                }
                else
                {
                    tmp = tmp.rightNode;
                }
            }
            int res = 0;
            if (tmp != null)
            {
                res = (n - tmp.charge.low) * tmp.charge.chargeRate + tmp.charge.minCharge;
            }
            else
            {
                res = -1;
            }
            return res;
        }

        public class IntervalTreeNode
        {
            public ChargeChart charge;
            public IntervalTreeNode leftNode;
            public IntervalTreeNode rightNode;

        }
    }

    public class ChargeChart
    {
        public int low;
        public int high;
        public int max;
        public int chargeRate;
        public int minCharge;
    }
}
