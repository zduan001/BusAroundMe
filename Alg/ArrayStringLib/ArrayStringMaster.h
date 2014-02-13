#pragma once
#include <string>
#include <vector>
#include <map>
using namespace std;

struct TrieNode
{
	TrieNode* children[26];
	bool end[26];
};

struct RandomNode
{
	int data;
	RandomNode* next;
	RandomNode* extra;
};

class ArrayStringMaster
{
public:
	ArrayStringMaster(void);
	~ArrayStringMaster(void);
	void ArrangeNegtivePositive(int[], int);
	int Read(char*, int);
	void RemoveADoubleB(char*);
	bool CheckInterLeave(char*, char*, char*);
	std::vector<char> FindMaxConseq(std::string input);
	vector<char> FindLongestRepeatSubStr(string input);
	string FindMinWindow(string s, string t);
	RandomNode* CloneRandomNode(RandomNode*);
	int maxProfit(vector<int> &prices);
	int FindMin(char str[], int length);
	void CleanString(char*);
	char* CleanStringII(char *);
private:
	void Swap(int[], int,int);
	RandomNode* CopyNode(RandomNode* node, map<RandomNode*, RandomNode*> nodeMap);
	int Read4096(char*);
	char* m_buf;
	int m_bufsize;
	int m_readcount;
};