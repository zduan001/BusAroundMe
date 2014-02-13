#include "stdafx.h"
#include "TreeQuestion.h"
#


TreeQuestion::TreeQuestion(void)
{
}


TreeQuestion::~TreeQuestion(void)
{
}

/*
	*Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to 
	•You may only use constant extra space.
	•You may assume that it is a perfect binary tree (ie, all leaves are at the same level, and every parent has two children).
*/
void TreeQuestion::PoupulateNextRightPointersInEachNode(TreeNodeWithNext* root)
{
	if(!root) 
	{
		return;
	}

	PoupulateNextRightPointersInEachNode(root->left);
	PoupulateNextRightPointersInEachNode(root->right);

	TreeNodeWithNext* left = root->left;
	TreeNodeWithNext* right = root->right;

	while(left && right)
	{
		left->next = right;
		left = left->right;
		right = right->left;
	}
}

void TreeQuestion::PoupulateNextRightPointersInEachNodeII(TreeNodeWithNext* root)
{
	if(!root || (!root->left && !root->right))
	{
		return;
	}

	TreeNodeWithNext* nextNode = GetLeftRightPointer(root->next);

	if(root->right != NULL)
	{
		root->right = nextNode;
	}
	
	if(root->left != NULL)
	{
		root->left->next = root->right != NULL? root->right: nextNode;
	}

	PoupulateNextRightPointersInEachNodeII(root->right);
	PoupulateNextRightPointersInEachNodeII(root->left);
}

TreeNodeWithNext* TreeQuestion::GetLeftRightPointer(TreeNodeWithNext* root)
{
	while(root != NULL)
	{
		if(root->left != NULL)
		{
			return root->left;
		}
		else if(root->right != NULL)
		{
			return root->right;
		}
		root = root->next;
	}

	return NULL;
}
