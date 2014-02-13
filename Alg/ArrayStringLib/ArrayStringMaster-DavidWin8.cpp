#include "stdafx.h"
#include "ArrayStringMaster.h"
#include <cstring>

#ifdef _CRT_SECURE_NO_DEPRECATE
#endif

ArrayStringMaster::ArrayStringMaster(void)
{
}


ArrayStringMaster::~ArrayStringMaster(void)
{
}

#pragma region array positive.
/* Level 2
http://www.geeksforgeeks.org/rearrange-positive-and-negative-numbers-publish/
An array contains both positive and negative numbers in random order. Rearrange the array elements so that positive and negative numbers are placed alternatively. Number of positive and negative numbers need not be equal. If there are more positive numbers they appear at the end of the array. If there are more negative numbers, they too appear in the end of the array.
*/
void ArrayStringMaster::ArrangeNegtivePositive(int input[], int n)
{
	//assume input only contain negative and positive number no 0.
	int left = 0;
	int right = n-1;
	while(left <=right)
	{
		while(left < n && input[left] < 0)
		{
			left++;
		}
		while(right>=0 && input[right] >0)
		{
			right--;
		}

		if(left<right)
		{
			Swap(input, left, right);
			left++;
			right--;
		}
	}

	int positiveIndex = left;

	if(positiveIndex > n/2)
	{
		//Todo: Reverse array before next step;
	}

	for(int i = 1;i< positiveIndex;i=i+2)
	{
		if(positiveIndex +i < n)
		{
			Swap(input, i, positiveIndex+i);
		}
	}
}

void ArrayStringMaster::Swap(int input[], int i, int j)
{
	int tmp = input[i];
	input[i] = input[j];
	input[j] = tmp;
}
#pragma endregion

#pragma region array positive.
/*
http://www.careercup.com/question?id=14424684
*/

int ArrayStringMaster::Read(char* buf, int length)
{
	int readlength;
	int requiredLength;
	char* res;
	//bool eof = false;

	while(m_bufsize >0)
	{
		int i = 0;
		while(i< m_bufsize && i<=length)
		{
			strncat(res, m_buf,1);
			m_buf ++;
			i++;
		}
		readlength += i;
		m_bufsize -= i;
		length -=i;

		if(0 == length) 
		{
			buf = res;
			return readlength;
		}
		length -= i;
		m_bufsize = Read4096(m_buf);
	}
}

int ArrayStringMaster::Read4096(char* buf)
{
	m_readcount ++;
	if(m_readcount == 5)
	{
		return 0;
	}
	int length = 4096;
	if(m_readcount < 4)
	{
		length = 2048;
	}

	char res[4097];
	for(int i = 0;i< 4096;i++)
	{
		res[i] = 'a';
	}
	
	res[length] = '\0';
	buf = res;
}
#pragma endregion