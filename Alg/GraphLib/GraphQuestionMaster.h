#pragma once
#include <vector>
#include <string>
#include <map>
#include <set>
#include <list>

using namespace std;

struct GraphNode
{
	char Value;
	set<GraphNode*> children;
	bool visited;
};



class GraphQuestionMaster
{
public:
	GraphQuestionMaster(void);
	~GraphQuestionMaster(void);
	vector<char> FindAlhaOrder(vector<string>);
	void Visit(GraphNode*, vector<char>&);
	void FindArticulationPoint(vector<vector<int>>);
	int VisitNodeAp(int*, int , int*,  int* , int* , int* , vector<vector<int>> );
};

