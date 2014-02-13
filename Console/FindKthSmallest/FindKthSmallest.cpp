// FindKthSmallest.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#define INT_MIN = -100000

int FindKthSmallest(int a[], int n, int b[], int m, int k)
{
	int i = k*n/(n+m);
	int j = k -i -1;

	int a_1 = ((i-1)<0? -10000 : a[i-1]);
	int b_1 = ((j-1) <0? -10000: b[j-1]);
	int a0 = ( i == n? 100000: a[i]);
	int b0 = (j ==m? 100000: b[j]);

	if(a0>b_1 && a0< b0)
		return a0;
	if(b0>a_1 && b0< a0)
		return b0;

	if(a0<b0)
	{
		return FindKthSmallest(a+i+1, n-i-1, b, j, k-i-1);
	}
	else
	{
		return FindKthSmallest(a, i, b+j+1, m-j -1, k-j-1);
	}
}


int _tmain(int argc, _TCHAR* argv[])
{

	return 0;
}

