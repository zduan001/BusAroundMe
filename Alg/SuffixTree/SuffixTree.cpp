#include "stdafx.h"
#include "SuffixTree.h"

CSuffixTree::CSuffixTree(void)
{
	for(int i = 0;i<26;i++)
	{
		children[i] = NULL;
	}
}

CSuffixTree::~CSuffixTree(void)
{
}

void CSuffixTree::CreateSuffixTree(char *input)
{
	while(*input != '\0')
	{
		int offset = tolower(*input) - 'a';

		if(!children[offset])
		{
			children[offset] = new CSuffixTree();
		}
		CreateSuffixTreeNode(input + 1, children[offset]);
		input++;
	}
}

void CSuffixTree::CreateSuffixTreeNode(char *input, CSuffixTree *node)
{
	int offset = tolower(*input) - 'a';

	if(!node->children[offset])
	{
		node->children[offset] = new CSuffixTree();
	}
	if(*(input+1) == '\0')
	{
			end[offset] = true;
			return;
	}
	else
	{
		CreateSuffixTreeNode(input+1, children[offset]);
	}
}