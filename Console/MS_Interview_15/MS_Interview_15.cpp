// MS_Interview_15.cpp : Defines the entry point for the console application.
//

//http://www.geeksforgeeks.org/mircosoft-interview-15/

#include "stdafx.h"
#include <stdlib.h>


#pragma region aaaaaaaaaabcccccc -> a10bc6
//Ques1. Write code for run -length encoding of a given string in-place (without using any extra memory).
// Sample Input: aaaaaaaaaabcccccc
// Output: a10bc6
void AddNum(char** tail, char tmp, int count)
{
	**tail = tmp;
	(*tail) ++;
	char num[65];
	char* buff = &(num[0]);
	_itoa_s(count,num,65,10);
	while( *buff != '\0')
	{
		**tail = *buff;
		(*tail)++;
		buff++;
	}
}


void ShrinkString(char* s)
{
	char* res = s;
	char tmp = *s;
	int count = 1;
	char* tail= s;
	s++;
	while(*s != '\0')
	{
		if(tmp == *s || (tmp != *s && count ==0))
		{
			tmp = *s;
			count++;
			s++;
		}
		else
		{
			if(count ==1)
			{
				*tail= tmp;
				tail++;
				count = 0;
			}
			else
			{
				AddNum(&tail, tmp, count);
				count = 0;
			}
			tmp = *s;
		}
	}
	AddNum(&tail, tmp, count);
	count = 0;
	*tail = '\0';
}
#pragma endregion

#pragma region integer to string
char* iToa(int count)
{
	if(count == 0)
	{
		char res[] = "0\0";
		return res;
	}
	bool isnegative = false;
	if(count <0)
	{
		isnegative = true;
		count = -count;
	}
	char res[65];
	int i = 0;
	while (count != 0)
	{
		int tmp = count %10;
		res[i] = '0' + tmp;
		count = count /10;
		i ++;
	}

	char* result = (char*)malloc(sizeof(char) * (i+2));
	char*tmp = result;
	if(isnegative)
	{
		*tmp = '-';
		tmp ++;
	}
	for(int j = i ;j>=0;j--)
	{
		*tmp = res[j];
		tmp++;
	}
	*tmp ='\0';
	return result;
}
#pragma endregion

int _tmain(int argc, _TCHAR* argv[])
{
	char input[] = "aaaaaaaaaabcccccc";
	ShrinkString(input);
	char* tmp = iToa(-123);
	tmp = iToa(0);
	tmp = iToa(123);
	return 0;
}

