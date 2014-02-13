// SegmentTree.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdio.h>
#include <math.h>

int getSumUtil(int * st, int segmentStart, int segmentEnd, int queryStart, int queryEnd, int index)
{
	// segment is part of query
	if(queryStart <= segmentStart && queryEnd >= segmentEnd)
	{
		return st[index];
	}

	//segment is out of the query 
	if(queryStart > segmentEnd || queryEnd < segmentStart)
	{
		return 0;
	}

	int mid = segmentStart + (segmentEnd - segmentStart) /2;
	return getSumUtil(st, segmentStart, mid, queryStart, queryEnd, 2*index +1) +
			getSumUtil(st, mid+1,segmentEnd, queryStart, queryEnd, 2*index +2);
}

int getSum(int* st, int n , int queryStart, int queryEnd)
{
	if(queryStart <0 || queryEnd > n-1 || queryEnd < queryStart)
	{
		return -1;
	}
	return getSumUtil(st, 0, n-1, queryStart, queryEnd, 0);
}

void updateUtil(int* st, int segmentStart, int segmentEnd, int index, int diff)
{
	if(index < segmentStart || index > segmentEnd)
	{
		return;
	}

	st[index] += diff;
	if(segmentStart != segmentEnd)
	{
		int mid = segmentStart + (segmentEnd - segmentStart) /2;
		updateUtil(st, segmentStart, mid, 2*index+1,diff);
		updateUtil(st, mid+1, segmentEnd, 2*index +2, diff);
	}
}

void Update(int* st, int n, int index, int diff)
{
	if(index <=0 || index > n-1)
	{
		return;
	}
	updateUtil(st, 0, n-1, index, diff);
}

int ConstructSTUtil(int arr[], int startIndex, int endIndex, int* st, int index)
{
	if(startIndex == endIndex)
	{
		st[index] = arr[startIndex];
		return st[index];
	}

	int mid = startIndex + (endIndex-startIndex) /2;
	st[index] = ConstructSTUtil(arr, startIndex, mid, st, 2 * index +1)
		+ ConstructSTUtil(arr, mid+1, endIndex, st, 2 * index +2);
	return st[index];
}


int* ConstructST(int arr[], int n)
{
	int x = (int) ceil(log((double)n) / log(2.0));
	int max_size = 2 * (int) pow( (double)2, x) -1;
	int* st = new int[max_size];
	ConstructSTUtil(arr, 0, n-1, st, 0);
	return st;
}

int _tmain(int argc, _TCHAR* argv[])
{
	int arr[] = {1, 3, 5, 7, 9, 11};
    int n = sizeof(arr)/sizeof(arr[0]);
 
    // Build segment tree from given array
    int *st = ConstructST(arr, n);
 
    // Print sum of values in array from index 1 to 3
    printf("Sum of values in given range = %d\n", getSum(st, n, 1, 3));
 
    // Update: set arr[1] = 10 and update corresponding segment
    // tree nodes
    Update(st, n, 1, 7);
 
    // Find sum after the value is updated
    printf("Updated sum of values in given range = %d\n", getSum(st, n, 1, 3));

	return 0;
}

