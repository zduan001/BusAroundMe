using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console.DP
{
    public class _004_MultiplicationOfNumbers
    {
        /*
         * There is an array A[N] of N numbers. You have to compose an array Output[N] such that Output[i] 
         * will be equal to multiplication of all the elements of A[N] except A[i]. Solve it without division 
         * operator and in O(n).
         */
        // contruct 2 int[N] array, 
        // Array 1. each element 'value is the 0-i-1 element times .
        // Array 2. each element's value is the i+1 - n-1 elements product.
        // then creat the third array each element is the Array1[i] * array2[i];
        // I have the assumption that there is no overflow.
    }
}
