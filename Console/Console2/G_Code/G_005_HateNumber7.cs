using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_005_HateNumber7
    {
        /*
         * 一个特殊的国家忌讳7这个数字，所有包含7的数字他们都不用，改用下一个数字，比如7他们用8代替，17用19代替，给定这个国家的数字，翻译成我们用的数字。 
         */
        /// <summary>
        /// Some one mentioned this is like a 9th decimal quesiton. actually it is. but how to solve this problem in code?
        /// or I can think of every 10 number this is a 7
        ///  every 100 there are 19;
        ///  every 1000 there are 271
        ///  
        /// method 2: for example number 1259 = 1 * (9^3) + 2 * (9^2) + 5 * (9^1) + (9-1);
        /// hope the method 2 works. I will try to write code tomorrow.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int GetRealNumber(int input)
        {

            return 0;
        }
    }
}
