#pragma once
struct RectangleTemplate
{
	int length;
	int width;
	int value;
};

class DPProblems
{
public:
	DPProblems(void);
	~DPProblems(void);
	int FindMaxValue(int, int, RectangleTemplate[], int);
};

