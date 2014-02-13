using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_1_33_MatrixLib
    {
        /*
         * Matrix library. Write a library Matrix that implements the following API:
         * public class Matrix
         * static     double  dot(double[] x, double[] y)            vector dot product 
         * static double[][]  mult(double[][] a, double[][] b)       matrix-matrix product 
         * static double[][]  transpose(double[][] a)                transpose 
         * static   double[]  mult(double[][] a, double[] x)         matrix-vector product 
         * static   double[]  mult(double[] y, double[][] a)         vector-matrix product
         */
        public double dot(double[] x, double[] y)
        {
            if (x == null || y == null) throw new ArgumentException();
            if (x.Length == 0 || y.Length == 0) throw new ArgumentException();
            if (x.Length != y.Length) throw new ArgumentException();

            double res = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                res += x[i] * y[i];
            }

            return res;
        }

        public double[,] mult(double[,] x, double[,] y)
        {
            if (x == null || y == null) throw new ArgumentException();
            int xn = x.GetLength(0);
            int xm = x.GetLength(1);
            int yn = y.GetLength(0);
            int ym = y.GetLength(1);

            if (xn == 0 || xm == 0 || yn == 0 || ym == 0) throw new ArgumentException();
            if (xm != yn) throw new ArgumentException();

            double[,] res = new double[xn, ym];

            for (int i = 0; i < xn; i++)
            {
                for (int j = 0; j < ym; j++)
                {
                    double tmp = 0.0;
                    for (int k = 0; k < xm; k++)
                    {
                        tmp += x[i, k] * y[k, j];
                    }
                    res[i, j] = tmp;
                }
            }
            return res;
        }

        public double[,] transpose(double[,] x)
        {
            if (x == null ) throw new ArgumentException();
            int xn = x.GetLength(0);
            int xm = x.GetLength(1);
            if (xn == 0 || xm == 0) throw new ArgumentException();

            double[,] res = new double[xm, xn];

            for (int i = 0; i < xm; i++)
            {
                for (int j = 0; j < xn; j++)
                {
                    res[j, i] = x[i, j];
                }
            }
            return res;
        }

        public double[] mult(double[,] x, double[] y)
        {
            if (x == null || y == null) throw new ArgumentException();
            int xn = x.GetLength(0);
            int xm = x.GetLength(1);
            int yn = y.Length;

            if (xn == 0 || xm == 0 || yn == 0) throw new ArgumentException();
            if (xm != yn) throw new ArgumentException();

            double[] res = new double[xn];

            for (int i = 0; i < xn; i++)
            {
                double tmp = 0.0;
                for (int k = 0; k < xm; k++)
                {
                    tmp += x[i, k] * y[k];
                }
                res[i] = tmp;
            }
            return res;
        }

        public double[] mult(double[] x, double[,] y)
        {
            if (x == null || y == null) throw new ArgumentException();
            int xm = x.Length;
            int yn = y.GetLength(0);
            int ym = y.GetLength(1);

            if (yn == 0 || ym == 0 || xm == 0) throw new ArgumentException();
            if (xm != yn) throw new ArgumentException();

            double[] res = new double[ym];
            for (int i = 0; i < ym; i++)
            {
                double tmp = 0.0;
                for (int j = 0; j < xm; j++)
                {
                    tmp += x[j] * y[j, i];
                }
                res[i] = tmp;
            }
            return res;
        }
    }
}
