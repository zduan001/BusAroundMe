#pragma once
#include "TreeNodeWithNext.h"

class TreeQuestion
{
public:
	TreeQuestion(void);
	~TreeQuestion(void);
	void PoupulateNextRightPointersInEachNode(TreeNodeWithNext* root);
	void PoupulateNextRightPointersInEachNodeII(TreeNodeWithNext* root);
	TreeNodeWithNext* GetLeftRightPointer(TreeNodeWithNext* root);
};

