#pragma once
class TreeNodeWithNext
{
public:
	TreeNodeWithNext(void);
	~TreeNodeWithNext(void);
	TreeNodeWithNext* left;
	TreeNodeWithNext* right;
	TreeNodeWithNext* next;
	int value;
	TreeNodeWithNext* ConstructTreeNodeWithNext(int[],int, int);
};

