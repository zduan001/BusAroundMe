// CountTheWords.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdio.h>

//http://www.geeksforgeeks.org/count-words-in-a-given-string/

int CountTheWord(char* input)
{
	int countofWord = 0;
	bool inWord = false;
	while(*input != '\0')
	{
		if(*input == ' ' || *input == '\t' || *input == '\n')
		{
			inWord = false;
		}
		else if( !inWord)
		{
			countofWord ++;
			inWord = true;
		}
		input++;
	}

	return countofWord;
}

int _tmain(int argc, _TCHAR* argv[])
{
	char str[] = "One two          three\n  four\nfive  ";
	printf("No. of Word:  %u\n", CountTheWord(str));

	return 0;
}



