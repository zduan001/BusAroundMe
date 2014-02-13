#pragma once
#include <vector>                                                                                                             
class CInsertRange
{
public:
	CInsertRange(void);
	~CInsertRange(void);
	void InsertRange(std::vector<std::pair<int,int>> &, std::pair<int,int>);
};

