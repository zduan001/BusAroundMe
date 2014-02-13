using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_007_Robot
    {
        /*
         * 直线上有一个机器人从原点开始移动，每次可以向左移，也可以向右移，移动 n步，再回到原点的概率是多少, 可以写程序实现。
         */
        public double FindPosibility(int n)
        {
            int ontarget = 0;
            int notOnTarget = 0;
            Worker(n, 0, 0, ref ontarget, ref notOnTarget);

            double res = (double)ontarget / (ontarget + notOnTarget);
            return res;

        }

        public void Worker(int n, int k, int position, ref int ontarget, ref int notOnTarget)
        {
            if (n == k)
            {
                if (position == 0)
                {
                    ontarget++;
                }
                else
                {
                    notOnTarget++;
                }
            }
            else
            {
                Worker(n, k + 1, position + 1, ref ontarget, ref notOnTarget);
                Worker(n, k + 1, position - 1, ref ontarget, ref notOnTarget);
            }
        }
    }
}
