using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_1_35_DiceSimulation
    {
        /*
         */
        public double[] DiceProb()
        {
            int SIDES = 6; 
            double[] dist = new double[2 * SIDES + 1]; 
            for (int i = 1; i <= SIDES; i++) 
                for (int j = 1; j <= SIDES; j++) 
                    dist[i + j] += 1.0;
            for (int k = 2; k <= 2 * SIDES; k++) 
                dist[k] /= 36.0;

            return dist;
        }

        public double[] TestDic()
        {
            int Max = 99999999;
            int SIDES = 6;
            Random ran = new Random((int)DateTime.Now.ToOADate());
            double[] dist = new  double[2*SIDES +1];
            for (int i = 0; i < Max; i++)
            {
                dist[ran.Next(1, 7) + ran.Next(1,7)] ++;
            }
            for (int i = 0; i < dist.Length; i++)
            {
                dist[i] /= Max;
            }

            return dist;
        }
    }
}
