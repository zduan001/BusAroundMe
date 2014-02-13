#pragma once
#include <stack>

using namespace std;

class StackWithMin
{

public:
	StackWithMin(void);
	~StackWithMin(void);
	int Min();
	void Push(int);
	int Pop();
private:
	stack<int> _stack;
	stack<int> minStack;
};

