using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_035_IntegerInStrings
    {
        /*
         * Given a string of sorted integers, e.g. “1 52 69 456789 994546566” and a a number e.g. 69. You need to tell if it is in the input, e.g. 69=>true.
         */
        /// <summary>
        /// the following method is too slow. should use atoi(), (for strings that length is different no need atoi())  and binary search.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsIntegerInStrings(string[] input, int value)
        {
            StringBuilder sb = new StringBuilder();
            while (value != 0)
            {
                sb.Insert(0, (value % 10).ToString());
            }

            foreach (string s in input)
            {
                if (sb.ToString() == s)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
