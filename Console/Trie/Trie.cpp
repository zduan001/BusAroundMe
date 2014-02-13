// Trie.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define ALPHABET_SIZE (26)
#define ARRAY_SIZE(a) sizeof(a)/sizeof(a[0])

typedef struct trie_node trie_node_t;
struct trie_node
{
	bool end[ALPHABET_SIZE];
	trie_node_t* children[ALPHABET_SIZE];
};

void Insert(trie_node_t * root, char* input)
{
	if(root->children[input[0]-'a'] == NULL)
	{
		root->children[input[0]-'a'] = new trie_node_t();
	}

	if(*(input+1) == '\0')
	{
		root->end[input[0]-'a'] = true;
	}
	else
	{
		Insert(root->children[input[0] -'a'], input+1);
	}
}

bool Search(trie_node_t* root, char* input)
{
	if(*input == '\0')
	{
		return false;
	}
	if(root->children[input[0]-'a'] != NULL)
	{
		if(root->end[input[0]-'a'] == true && *(input+1) == '\0')
		{
			return true;
		}
		else
		{
			return Search(root->children[input[0]-'a'], input+1);
		}
	}
	return false;
}

bool Delete(trie_node_t* root, char* input)
{
	if(*input == '\0') return false;
	int index = input[0] - 'a';

	// trie does not contain the input.
	if(root->children[index] == NULL)
	{
		return false;
	}
	else
	{
		if(*(input+1) == '\0' && root->children[index] != NULL && root->end[index] == true)
		{
			root->end[index] = false;
			bool hasChildren = false;
			for(int i = 0;i< ALPHABET_SIZE;i++)
			{
				if(root->children[index]->children[i] != NULL)
				{
					hasChildren = true;
					break;
				}
			}
			if(!hasChildren)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		else
		{
			if(Delete(root->children[index], input+1))
			{
				//delete root->children[index];
				root->children[index] = NULL;
			}
			return false;
		}
	}
	
}

int _tmain(int argc, _TCHAR* argv[])
{
	char keys[][8] = {"the", "a", "there", "answer", "any", "by", "bye", "their"};
	trie_node_t* root = new trie_node_t();
	for(int i =0;i< ARRAY_SIZE(keys);i++)
	{
		Insert(root, keys[i]);
	}

	char output[][32] = {"Not present in trie", "Present in trie"};
	printf("%s --- %s\n", "the", output[Search(root, "the")] );
    printf("%s --- %s\n", "these", output[Search(root, "these")] );
    printf("%s --- %s\n", "their", output[Search(root, "their")] );
    printf("%s --- %s\n", "thaw", output[Search(root, "thaw")] );
	printf("%s --- %s\n", "the", output[Search(root, "the")] );
	printf("%s --- %s\n", "answer", output[Search(root, "answer")] );
	printf("%s --- %s\n", "by", output[Search(root, "by")] );
	printf("%s --- %s\n", "bye", output[Search(root, "bye")] );

	Delete(root, "the");
	printf("%s --- %s\n", "the", output[Search(root, "the")] );

	Delete(root, "answer");
	printf("%s --- %s\n", "answer", output[Search(root, "answer")] );

	Delete(root, "by");
	printf("%s --- %s\n", "by", output[Search(root, "by")] );
	printf("%s --- %s\n", "bye", output[Search(root, "bye")] );


	Delete(root, "bye");
	printf("%s --- %s\n", "bye", output[Search(root, "bye")] );

	Delete(root, "xxxx");
	printf("%s --- %s\n", "there", output[Search(root, "there")] );

	return 0;
}

