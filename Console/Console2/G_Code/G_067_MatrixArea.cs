using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_067_MatrixArea
    {
        /*
         * 一个图像的二维矩阵，给两个坐标，返回这两个坐标形成的长方形里面的点的和。如何预处理这个矩阵，使得获取结果的时间为constant time。
         */
        /*
         * 1. create a same size 2D array. each node's value is the sume of value of rectangle (0,0) to the point (i,j). this can be achieved O(n)
         * 2. if 2 nodes are (i,j)  and (k,l) the area is a2(k,l) - a2(k-i-1,l) - s2(k, l-j-1) + a2(i-1,j-1). O(1)
         */
    }
}
