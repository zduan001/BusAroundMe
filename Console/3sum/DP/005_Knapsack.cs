using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console.DP
{
    public class _005_Knapsack
    {
        /// <summary>
        /// Knapsack without repetition.
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="vaule"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>
        public int KnapsackNoRepetition(int[] weight, int[] value, int capacity)
        {
            int[,] res = new int[weight.Length, capacity + 1];

            for (int j = 0; j <= capacity; j++)
            {
                if (j - weight[0] >= 0)
                {
                    res[0, j] = value[0];
                }
            }

            for (int i = 1; i < weight.Length; i++)
            {
                for (int j = 0; j <= capacity; j++)
                {
                    int a = 0;
                    if (j - weight[i] >= 0)
                    {
                        a = res[i - 1, j - weight[i]] + value[i];
                    }
                    res[i, j] = Math.Max(res[i - 1, j], a);
                }
            }
            return res[weight.Length - 1, capacity];
        }

        /// <summary>
        /// Same DP method but use just 2(two)  1-D array.
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="value"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>
        public int KnapsackNoRepititionOneDArray(int[] weight, int[] value, int capacity)
        {
            int[] prev = new int[capacity + 1];
            int[] curr = new int[capacity + 1];

            // no need to initialize the first row anymore
            // main for loop will take care of it.
            //for (int j = 0; j <= capacity; j++)
            //{
            //    if (j - weight[0] >= 0)
            //    {
            //        prev[j] = value[0];
            //    }
            //}

            for (int i = 0; i < weight.Length; i++)
            {
                for (int j = 0; j <= capacity; j++)
                {
                    int a = 0;
                    if (j - weight[i] >= 0)
                    {
                        a = prev[j - weight[i]] + value[i];
                    }
                    curr[j] = Math.Max(prev[j], a);
                }
                prev = curr;
                curr = new int[capacity + 1];
            }
            return prev[capacity];
        }

        /*
         * 初始化的细节问题
 
        我们看到的求最优解的背包问题题目中，事实上有两种不太相同的问法。有的题目要求“恰好装满背包”时的最优解，
        有的题目则并没有要求必须把背包装满。一种区别这两种问法的实现方法是在初始化的时候有所不同。
 
        如果是第一种问法，要求恰好装满背包，那么在初始化时除了f[0]为0其它f[1..V]均设为-∞，这样就可以
        保证最终得到的f[N]是一种恰好装满背包的最优解。
 
        如果并没有要求必须把背包装满，而是只希望价格尽量大，初始化时应该将f[0..V]全部设为0。
 
        为什么呢？可以这样理解：初始化的f数组事实上就是在没有任何物品可以放入背包时的合法状态。如果要求背包恰好装满，
        那么此时只有容量为0的背包可能被价值为0的nothing“恰好装满”，其它容量的背包均没有合法的解，属于未定义的状态，
        它们的值就都应该是-∞了。如果背包并非必须被装满，那么任何容量的背包都有一个合法解“什么都不装”，这个解的价值为0，
        所以初始时状态的值也就全部为0了。
 
        这个小技巧完全可以推广到其它类型的背包问题，

         */
        /// <summary>
        /// Same DP method but use just 1(one)  1-D array.
        /// notice how the inner loop from capacity to 0.
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="value"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>
        public int KnapsackNoRepititionOneOneDArray(int[] weight, int[] value, int capacity)
        {
            int[] res = new int[capacity + 1];

            // no need to initialize the first row anymore
            // main for loop will take care of it.
            //for (int j = 0; j <= capacity; j++)
            //{
            //    if (j - weight[0] >= 0)
            //    {
            //        res[j] = value[0];
            //    }
            //}

            for (int i = 0; i < weight.Length; i++)
            {
                for (int j = capacity; j >= 0; j--)
                {
                    int a = 0;
                    if (j - weight[i] >= 0)
                    {
                        a = res[j - weight[i]] + value[i];
                    }
                    res[j] = Math.Max(res[j], a);
                }
            }
            return res[capacity];
        }


        /*
         * 
            前面的伪代码中有 for v=V..1，可以将这个循环的下限进行改进。
 
            由于只需要最后f[v]的值，倒推前一个物品，其实只要知道f[v-w[n]]即可。
            以此类推，对以第j个背包，其实只需要知道到f[v-sum{w[j..n]}]即可，即代码中的
                for i=1..N
                for v=Capacity..0
 
            可以改成
                for i=1..n
                bound=max{Capacity-sum{value[i..n]},weight[i]} // this doesn't sound right.
                for v=Capacity..bound
 
            这对于V比较大时是有用的。

         */
        /// <summary>
        /// Same DP method but use just 1(one)  1-D array and a lower bound
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="value"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>
        public int KnapsackNoRepititionOneOneDArrayIncreasedLowBound(int[] weight, int[] value, int capacity)
        {
            int[] res = new int[capacity + 1];

            for (int i = 0; i < weight.Length; i++)
            {
                int totalValue = 0;
                for (int k = i; k < value.Length; k++)
                {
                    totalValue += value[k];
                }
                int bound = Math.Max(capacity - totalValue, weight[i]);

                for (int j = capacity; j >= bound; j--)
                {
                    int a = 0;
                    if (j - weight[i] >= 0)
                    {
                        a = res[j - weight[i]] + value[i];
                    }
                    res[j] = Math.Max(res[j], a);
                }
            }
            return res[capacity];
        }

        /// <summary>
        /// Similar problem but this time each itm can be taken repeatly, as there are
        /// unlimit of each item.
        /// 
        /// notice the main is so similar to the 1(one) 1-D array solution of nonrepeatition
        /// methos. hmm. not so similar. the two methods basic ideas are fundamentally different.
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="value"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>
        public int KnapsackWithRepitition(int[] weight, int[] value, int capacity)
        {
            int[] res = new int[capacity + 1];
            int max = 0;
            for (int i = 0; i <= capacity; i++)
            {
                for (int j = 0; j < weight.Length; j++)
                {
                    int a = 0;
                    if (i - weight[j] >= 0)
                    {
                        a = res[i - weight[j]] + value[j];
                    }
                    max = max > a ? max : a;
                }
                res[i] = max;
                max = 0;
            }
            return res[capacity];
        }

        /// <summary>
        /// Similar problem but this time each itm can be taken repeatly, as there are
        /// unlimit of each item.
        /// 
        /// notice the main is so similar to the 1(one) 1-D array solution of nonrepeatition
        /// methos. hmm. not so similar. 
        /// Now they are same.
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="value"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>
        public int KnapsackWithRepititionReverseLoop(int[] weight, int[] value, int capacity)
        {
            int[] res = new int[capacity + 1];
            for (int j = 0; j < weight.Length; j++)
            {
                for (int i = 0; i <= capacity; i++)
                {
                    int a = 0;
                    if (i - weight[j] >= 0)
                    {
                        a = res[i - weight[j]] + value[j];
                    }
                    res[i] = Math.Max(res[i], a);
                }
            }
            return res[capacity];
        }
    }
}
