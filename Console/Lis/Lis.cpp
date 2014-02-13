// Lis.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdio.h>
#include <iostream>


int FindLis(int array[], int length)
{
	int* tracker = (int*) malloc(sizeof(int) *length);
	int* prev = (int*) malloc(sizeof(int) * length);
	for(int i = 0;i<length;i++)
	{
		* (tracker+i) = 1;
		prev[i] = -1;
	}
	
	for(int i = 1;i< length;i++)
	{
		for(int j = 0;j<i;j++)
		{
			if(array[i] > array[j] && tracker[j] + 1 > tracker[i])
			{
				tracker[i] = tracker[j] + 1;
				prev[i] = j;
			}
		}
	}

	if(prev[length-1] != -1)
	{
		printf("%u ,", array[length-1]);
	}

	int i = length -1;
	while(i >=0)
	{
		if(prev[i] >=0)
		{
			printf("%u ,", array[prev[i]]);
			i = prev[i];
		}
		else
		{
			i--;
		}

	}

	printf("\n");
	return tracker[length-1];
}

int FindListRecursive(int arr[], int length)
{
	if (length == 1)
	{
		return 1;
	}

	int res = 1;
	int tmp = res;

	for(int i = 1;i<length;i++)
	{
		tmp = FindListRecursive(arr, i);
		if(tmp +1> res && arr[length-1] > arr[i-1])
		{
			res = tmp +1;
		}
	}
	return res;
}


int _tmain(int argc, _TCHAR* argv[])
{
	int arr[] = { 10, 22, 9, 33, 21, 50, 41, 60,80 };
	//int arr[] = { 1, 100, 2, 3, 4, 5, 41, 60,80 };
	int n = sizeof(arr)/sizeof(arr[0]);
	printf("lis is %u\n", FindLis(arr, n));
	printf("list is %u\n", FindListRecursive(arr,n));
	return 0;
}

