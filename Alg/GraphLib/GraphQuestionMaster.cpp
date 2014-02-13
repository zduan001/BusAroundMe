#include "stdafx.h"
#include "GraphQuestionMaster.h"


GraphQuestionMaster::GraphQuestionMaster(void)
{
}


GraphQuestionMaster::~GraphQuestionMaster(void)
{
}

vector<char> GraphQuestionMaster::FindAlhaOrder(vector<string> input)
{
	//Assume 26 charaters, can be changed easily.
	//Assume all lower case.
	GraphNode* nodes[26];
	for(int i = 0;i< 26;i++)
	{
		nodes[i]->Value = 'a' +i;
	}

	for(int i = 0;i< (int)input.size()-1;i++)
	{
		int j = 0;
		while(input[i][j] == input[i+1][j])
		{
			j++;
		}

		if(nodes[input[i][j+1]-'a']->children.find(nodes[input[i][j+1]]-'a') == nodes[input[i][j+1]-'a']->children.end())
		{
			nodes[input[i][j+1]]->children.insert(nodes[input[i][j+1]]);
		}

	}

	vector<char> res;
	for(int i = 0; i< 26;i++)
	{
		if(!nodes[i]->visited )
		{
			Visit(nodes[i], res);
		}
	}

	return res;
}

void GraphQuestionMaster::Visit(GraphNode* node, vector<char>& res)
{
	for(set<GraphNode*>::iterator it = node->children.begin(); it!= node->children.end(); ++it)
	{
		if(!((*it)->visited))
		{
			Visit(*it, res);
		}
	}
	node->visited = true;
	res.push_back(node->Value);
}

void GraphQuestionMaster::FindArticulationPoint(vector<vector<int>> input)
{
	int n = input.size();
	int* parent = new int[n];
	int* low = new int[n];
	int* level = new int[n];
	int* childrenCount = new int[n];
	
	for(int i = 0;i< n;i++)
	{
		parent[i] = -1;
		low[i] = 9999;
		level[i] = -1;
		childrenCount = 0;
	}
	int step = 0;
	for(int i = 0;i< n ;i ++)
	{
		if(level[i] ==-1)
		{
			VisitNodeAp(&step,i, childrenCount, parent, low, level, input);
		}
	}
}

int GraphQuestionMaster::VisitNodeAp(int* step, int node,int* childrenCount, int* parent, int* low, int* level, vector<vector<int>> input)
{
	vector<int> children = input[node];
	int size = children.size();

	level[node] = *step;
	low[node] = *step;
		
	int min = 1000;
	for(int i = 0;i< size;i++)
	{
		if(level[children[i]] == -1)
		{
			childrenCount[node] ++;
			parent[children[i]] = node;
			*step = *step+1;
			int lowest = VisitNodeAp(step, children[i],childrenCount, parent, low, level, input);
			min = min < lowest? min : lowest;
		}
	}

	low[node] = low[node] < min ? low[node] : min;
	
	
	return low[node];
}