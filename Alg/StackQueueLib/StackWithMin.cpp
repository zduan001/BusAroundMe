#include "stdafx.h"
#include "StackWithMin.h"


StackWithMin::StackWithMin(void)
{
}


StackWithMin::~StackWithMin(void)
{
}

int StackWithMin::Min()
{
	if(minStack.empty())
	{
		return -1;
	}
	return minStack.top();
}

int StackWithMin::Pop()
{
	if(_stack.empty())
	{
		return -1;
	}

	int res = _stack.top();
	_stack.pop();
	if(res == minStack.top())
	{
		minStack.pop();
	}

	return res;
}

void StackWithMin::Push(int input)
{
	if(minStack.empty() || input <= minStack.top())
	{
		minStack.push(input);
	}

	_stack.push(input);
}
