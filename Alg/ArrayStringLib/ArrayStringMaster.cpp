#include "stdafx.h"
#include "ArrayStringMaster.h"
#include <cstring>
#include <hash_map>
#include <hash_set>
#include <vector>
#include <map>
#include <deque>
#include <string>
#include <stack>

using namespace std;

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

#pragma region Read with Read4096
/*
http://www.careercup.com/question?id=14424684
*/

int ArrayStringMaster::Read(char* buf, int length)
{
	int readlength= 0;
	int requiredLength = 0;
	char* res = NULL;
	//bool eof = false;

	while(m_bufsize >0)
	{
		int i = 0;
		while(i< m_bufsize && i<=length)
		{
			//strncat(res, m_buf,1);
			m_buf ++;
			i++;
		}
		readlength += i;
		if(i == length) 
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

#pragma region RemoveADoubleB
/*
7. 处理一个字符串，删除里面所有的A，double所有的B例子，输入 CAABD, 输出是CBBD
要求in space , O (1), no extra memory cost,因为字符串处理变长的空间不算
From <http://www.mitbbs.com/article_t/JobHunting/32113349.html> 
*/
void ArrayStringMaster::RemoveADoubleB(char* input)
{
	// Assume only Capital letters are used. if lower case is allowed, code can be easily modified.
	int i=0, j=0;
	int countOfB = 0;
	while(input[j] != '\0')
	{
		if(input[j] == 'B') countOfB ++;
		if(input[j] == 'A')
		{
			j++;
		}
		else
		{
			input[i++] = input[j++];
		}
	}
	input[i] = input[j];

	int n = i +countOfB;
	while(i>0)
	{
		if(input[i] == 'B')
		{
			input[n--] = 'B';
		}
		input[n --] = input[i--];
	}
}
#pragma endregion

#pragma region string interleave
/*
http://leetcode.com/onlinejudge#question_97
Given s1, s2, s3, find whether s3 is formed by the interleaving of s1 and s2.

For example,
 Given:
s1 = "aabcc",
s2 = "dbbca",

When s3 = "aadbbcbcac", return true.
 When s3 = "aadbbbaccc", return false.

*/
bool ArrayStringMaster::CheckInterLeave(char* s1, char* s2, char* s3)
{
	// initial check l1 + l2 == l3 ....
	// no nulls
	if(*s1 == '\0' && *s2 == '\0' && *s3 == '\0')
		return true;

	if(*s1 == *s3 && *s2 != *s3)
	{
		return CheckInterLeave(s1+1, s2, s3+1);
	}
	else if(*s1 != *s3 && *s2 == *s3)
	{
		return CheckInterLeave(s1, s2+1, s3+1);
	}
	else if( *s1 == *s3 && *s2 == *s3)
	{
		return CheckInterLeave(s1, s2+1, s3+1) || CheckInterLeave(s1+1, s2, s3+1);
	}

	return false;
}
#pragma endregion

#pragma region Find longest Repest Word
/*
9. this is a sentence" => [t, h, i, s, i, s, a, s, e, n, t, e, n, c, e]
"thiis iss a senntencee" => [i, s, n, e]
"thiisss iss a senntttenceee" => [s, t, e]
"thiisss iss a sennnntttenceee" => [n]

From <http://www.mitbbs.com/article_t/JobHunting/32407699.html> 
*/
vector<char> ArrayStringMaster::FindMaxConseq(string input)
{
	std::vector<std::pair<char,int>> tracker;

	char currentChar = '-';
	int currenCount = 0;
	int maxCount = 0;
	unsigned i = 0;
	while(i<input.length())
	{
		if(input[i] == currentChar)
		{
			currenCount ++;
		}
		else
		{
			std::pair<char, int> p;
			p.first = currentChar;
			p.second = currenCount;
			tracker.push_back(p);
			maxCount = maxCount > currenCount ? maxCount : currenCount;
			currentChar = input[i];
			currenCount = 1;
		}
		i++;
	}

	std::pair<char, int> p;
	p.first = currentChar;
	p.second = currenCount;
	tracker.push_back(p);
	maxCount = maxCount > currenCount ? maxCount : currenCount;
	std::vector<char> res;
	for(i = 0;i< tracker.size();i++)
	{
		if(tracker.at(i).second == maxCount && tracker.at(i).first != ' ')
		{
			res.push_back(tracker.at(i).first);
		}
	}

	return res;
}
#pragma endregion

#pragma region 
vector<char> ArrayStringMaster::FindLongestRepeatSubStr(string input)
{
	vector<char> res;
	TrieNode* root = new TrieNode();
	int i = 0;
	int j = 0;
	int currentLength = 0;
	int maxLength = 0;
	vector<char> currentStr;

	while(i < input.length())
	{
		j = i;
		TrieNode* tmp = root;
		currentLength = 0;
		currentStr.clear();

		while(j< input.length())
		{
			if(tmp->children[input[j] - 'a'])
			{
				currentLength++;
				currentStr.push_back(input[j]);
			}
			else
			{
				tmp->children[input[j]- 'a'] = new TrieNode();
			}
			tmp = tmp -> children[input[j] - 'a'];
			j++;
		}

		if(currentLength > maxLength)
		{
			res.clear();
			for(int i = 0;i< currentStr.size();i++)
			{
				res.push_back(currentStr[i]);
			}
			maxLength = currentLength;
		}
		i++;
	}
	return res;
}
#pragma endregion

#pragma region MinSlideWindows for Sub string
string ArrayStringMaster::FindMinWindow(string s, string t)
{
	//map<char, pair<int,int>> _map;
	//for(int i = 0;i< (int)t.length;i++)
	//{
	//	if(_map.find(t[i]) == _map.end)
	//	{
	//		pair<int, int> tmp;
	//		tmp.first = 1;
	//		_map.insert(pair<char, pair<int,int>>(s[i], tmp));
	//	}
	//	else
	//	{
	//		_map.find(t[i])->second.first ++;
	//	}
	//}
	//int count = 0;
	//deque<int> tracker;
	//int start, end;
	//int length = 100000;

	//for(int i= 0;i<(int)s.length;i++)
	//{
	//	if(_map.find(s[i]) != _map.end)
	//	{
	//		if(s[i] == s[tracker.front])
	//		{
	//			if(_map.find(s[i])->second.second >= _map.find(s[i])->second.first && count == _map.count)
	//			{
	//				tracker.pop_front();
	//				tracker.push_back(i);
	//			}
	//			else
	//			{
	//				tracker.push_back(i);
	//				if(_map.find(s[i])->second.second == 0)
	//				{
	//					count ++;
	//				}
	//				_map.find(s[i])->second.second ++;
	//			}
	//		}
	//		else
	//		{
	//			tracker.push_back(i);
	//			_map.find(s[i])->second.second ++;
	//		}
	//	}

	//	if(count== _map.count && length > tracker.end - tracker.front)
	//	{
	//		start = tracker.front;
	//		end = tracker.back;
	//		length = tracker.end-tracker.front;
	//	}
	//}

	//string res = s.substr(start, end-start+1);
	//return res;
	return "";

}
#pragma end region

#pragma region RandomNode
RandomNode* ArrayStringMaster::CloneRandomNode(RandomNode* root)
{
	map<RandomNode*, RandomNode*> _map;
	return CopyNode(root, _map);
}

RandomNode* ArrayStringMaster::CopyNode(RandomNode* node, map<RandomNode*, RandomNode*> nodeMap)
{
	if(node == NULL)
	{
		return NULL;
	}

	if(nodeMap.find(node) == nodeMap.end())
	{
		RandomNode* newNode = new RandomNode();
		nodeMap.insert(pair<RandomNode*, RandomNode*>(node, newNode));
		newNode->data = node->data;
		newNode->next = CopyNode(node->next, nodeMap);
		newNode->extra = CopyNode(node->extra, nodeMap);
		return newNode;
	}
	else
	{
		return nodeMap.find(node)->second;
	}
}
#pragma endregion

#pragma region max profit II
int ArrayStringMaster::maxProfit(vector<int> &prices)
{
	if(prices.size() <2) 
		return 0;
	int maxProfit = 0;
	int buyIndex = -1;
	int i = 0;
	while(i+1 < prices.size())
	{
		if(buyIndex != -1)
		{
			if(prices[i]>prices[i+1])
			{
				maxProfit += (prices[i] - prices[buyIndex]);
				buyIndex = -1;
			}
		}
		else
		{
			if(prices[i]<prices[i+1])
			{
				buyIndex = i;
			}
		}
		i++;
	}

	if(buyIndex != -1)
	{
		maxProfit += prices[prices.size() -1]- prices[buyIndex];
	}
	return maxProfit;

}
#pragma endregion

#pragma region 
/*
http://www.geeksforgeeks.org/dynamic-programming-set-28-minimum-insertions-to-form-a-palindrome/
*/
int ArrayStringMaster::FindMin(char str[], int n)
{
	int tracker[100][100];
	for(int i = 0;i< n;i++)
	{
		tracker[i][i] = 0;
	}

	for(int length = 1;length< n;length++)
	{
		for(int start = 0;start < n;start++)
		{
			if(start+length < n)
			{
				if(str[start] == str[start+length])
				{
					tracker[start][start+length] = tracker[start+1][start+length-1];
				}
				else
				{
					int left = tracker[start][start+length-1];
					int right = tracker[start+1][start+length];
					int res = left< right? left:right;
					tracker[start][start+length] = res+1;
				}
			}
		}
	}
	return tracker[0][n-1];
}
#pragma endregion 

#pragma region ClearnString
/*
http://www.geeksforgeeks.org/remove-a-and-bc-from-a-given-string/
Given a string, eliminate all “b” and “ac” in the string, you have to replace 
them in-place, and you are only allowed to iterate over the string once. (Source Google Interview Question)
*/
// consider only lower case.
void ArrayStringMaster::CleanString(char* input)
{
	int index = 0;
	int runner = 0;
	char tmp = '\0';

	for(runner = 0;input[runner] != '\0';runner++)
	{
		if(input[runner] == 'b')
		{
			continue;
		}

		if(input[runner] == 'a' )
		{
			if( tmp == '\0')
			{
				tmp = 'a';
				continue;
			}
		}

		if(input[runner] == 'c' && tmp == 'a')
		{
			tmp = '\0';
			continue;
		}

		if(tmp != '\0' && input[runner] != 'a')
		{
			input[index++] = 'a';
			tmp = '\0';
		}

		input[index++] = input[runner];
	}

	input[index] = '\0';
	
}

/*
In this question the result string can not have "ac" or "b", a new string is allowed but once a char
is written in the new string, it can not be taken out.
*/
char* ArrayStringMaster::CleanStringII(char *input)
{
	char* res = new char();
	char* header = res;
	stack<char> tmp;

	for(int i = 0;input[i] != '\0';i++)
	{
		if(input[i] == 'b')
		{
			continue;
		}
		else if(input[i] == 'c')
		{
			if(tmp.empty())
			{
				*res = 'c';
				res++;
			}
			else
			{
				tmp.pop();
			}
		}
		else if(input[i] == 'a')
		{
			tmp.push('a');
		}
		else
		{
			if(tmp.empty())
			{
				*res = input[i];
				res ++;
			}
			else
			{
				while(!tmp.empty())
				{
					tmp.pop();
					*res = 'a';
					res++;
				}
				*res = input[i];
				res++;
			}
		}
	}
	while(!tmp.empty())
	{
		*res = 'a';
		res++;
		tmp.pop();
	}
	*res = '\0';

	return header;
}
#pragma endregion