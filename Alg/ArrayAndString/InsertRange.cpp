#include "stdafx.h"
#include "CInsertRange.h"


CInsertRange::CInsertRange(void)
{
}


CInsertRange::~CInsertRange(void)
{
}

void CInsertRange::InsertRange(std::vector<std::pair<int, int>> &input, std::pair<int, int> f)
{
	int first = f.first;
	int second = f.second;
	int size = input.size();

	int start = -1;
	int end = -1;

	// binary search can not be used here.
	int left = 0;
	int right = size-1;

	//O(lgn) to find how first of f landed.
	while(left <=right)
	{
		int mid = (left+right)/2;
		if(first <= input[mid].second && first >= input[mid].first)
		{
			first = input[mid].first;
			start = mid;
			break;
		}
		else if(first < input[mid].first)
		{
			right = mid-1;
		}
		else
		{
			left = mid +1;
		}
	}

	if(start == -1 && left <= size)
	{
		start = left;
	}

	// O(lgn) find where right end landed.
	left = 0;right = size-1;
	while(left<=right)
	{
		int mid = (left+ right)/2;
		if(second <=input[mid].second && second >=input[mid].first)
		{
			second = input[mid].second;
			end = mid;
			break;
		}
		else if(second < input[mid].first)
		{
			right = mid-1;
		}
		else
		{
			left = mid +1;
		}
	}

	if(end == -1 && right >=0)
	{
		end = right;
	}

	// case 1. both start and end with in vector range. and start <= end
	// Solution: remove from start to end, add new element to start.

	// case 2. both start and end with in vector range, but start >end and start = end +1;
	// a new range should be add right between end and start.

	// case 3. end = -1 and start = 0; 
	// solution add range as the first place

	// case 4. start = -1, end = vector.size() -1;
	// solution add range to the last one in the vector

	
	if(start >=0 && start < end && end <= input.size()-1)
	{
		// case 1. 
		input.erase(input.begin() + start, input.begin() + end);
		f.first = first;
		f.second = second;
	}
	else if(start >= 0 && start <= input.size()-1 &&
		end >=0 && end <= input.size() -1 &&
		start == end +1)
	{
		//Case 2:
		start = start +1;
	}
	else if( start == 0 && end == -1)
	{
		//Case 3:
		start = 0;
	}
	else if(start = -1 && end == input.size() -1)
	{
		//Case 4:
		start = input.size() -1;
	}


	std::vector<std::pair<int,int>>::iterator it;
		it = input.begin();
		input.insert(it+start, f);


}
