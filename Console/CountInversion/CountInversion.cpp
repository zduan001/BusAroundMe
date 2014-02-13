// CountInversion.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdio.h>
#include <stdlib.h>
#include <iostream>


int mergeSort(int arr[], int array_Size);
int _mergSort(int arr[], int tmp[], int left, int right);
int Merger(int arr[], int tmp[], int left, int mid, int right);

int _tmain(int argc, _TCHAR* argv[])
{
	int arr[] = {2,4,1,3,5};
	std::cout<<mergeSort(arr, 5);
	getchar();
	return 0;
}

int mergeSort(int arr[], int array_Size)
{
	int* tmp = (int *)malloc(sizeof(int) * array_Size);
	return  _mergSort(arr, tmp, 0, array_Size-1);
}

int _mergSort(int arr[], int tmp[], int left, int right)
{
	int mid, inversion_Count = 0;
	if(right>left)
	{
		mid = (left + right)/2;
		inversion_Count += _mergSort(arr, tmp, left, mid);
		inversion_Count += _mergSort(arr, tmp, mid+1, right);

		inversion_Count += Merger(arr, tmp, left, mid, right);
	}
	return inversion_Count;
}

int Merger(int arr[], int tmp[], int left, int mid, int right)
{
	int inversion_Count=0;
	int i,j,k;
	i = left;
	k = left;
	j = mid;

	while(i<=mid-1 && j<=right) // I am still puzzled by i<=mid-1, why it is not i<=mid, left array is from left to mid.
	{
		if(arr[i] < arr[j])
		{
			tmp[k++] = arr[i++];
		}
		else
		{
			//for(int x = i;x<=mid-1;x++)
			//{
			//	printf("inversion is %d , %d \n",arr[x], arr[j]);
			//}
			tmp[k++] = arr[j++];
			inversion_Count += mid-i;
		}
	}

	while(i<=mid-1)
	{
		tmp[k++] = arr[i++];
	}

	while(j<= right)
	{
		tmp[k++] = arr[j++];
	}

	for(i = left;i<=right;i++)
	{
		arr[i] = tmp[i];
	}
	return inversion_Count;
}





