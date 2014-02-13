#include "stdafx.h"
#include "TreeNodeWithNext.h"


TreeNodeWithNext::TreeNodeWithNext(void)
{
}


TreeNodeWithNext::~TreeNodeWithNext(void)
{
}


TreeNodeWithNext* TreeNodeWithNext::ConstructTreeNodeWithNext(int input[], int length, int startIndex)
{
	if(startIndex >= length)
	{
		return NULL;
	}

	TreeNodeWithNext* root = new TreeNodeWithNext();
	root->value = input[startIndex];
	root->left = ConstructTreeNodeWithNext(input, length, startIndex *2+1);
	root->right = ConstructTreeNodeWithNext(input, length, startIndex *2 +2);

	return root;
}


 