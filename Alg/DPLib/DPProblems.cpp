#include "stdafx.h"
#include "DPProblems.h"


DPProblems::DPProblems(void)
{
}


DPProblems::~DPProblems(void)
{
}

int DPProblems::FindMaxValue(int length, int width, RectangleTemplate Temps[], int count)
{
	int trackerArray[100][100];
	for(int i = 0;i< length+1 ;i++)
	{
		trackerArray[0][i] = 0;
	}
	for(int i = 0;i<width+1;i++)
	{
		trackerArray[i][0] = 0;
	}

	for(int i = 1;i< length+1;i++)
	{
		for(int j = 1;j<width +1;j++)
		{
			int max = 0;
			for(int k= 0;k<count;k++)
			{
				int localMaxII = 0;
				for(int t = 0;t<2;t++)
				{
					RectangleTemplate c;
					if(t%2==0)
					{
						c.length = Temps[k].length;
						c.width = Temps[k].width;
					}
					else
					{
						c.length = Temps[k].width;
						c.width = Temps[k].length;
					}
					
					int localMax = 0;
					if(c.length <=i && c.width <=j)
					{
						int tmp = 0;
						for(int m = c.length;m<=i;m++)
						{
							tmp = 0;
							tmp += trackerArray[m-c.length][c.width];
							tmp += trackerArray[i-m][width];
							tmp += trackerArray[m][j-c.width];
							localMax = localMax>=tmp? localMax:tmp;
						}

						for(int v = c.width;v<=j;v++)
						{
							tmp = 0;
							tmp += trackerArray[c.length][v-c.width];
							tmp += trackerArray[i-c.length][v];
							tmp += trackerArray[i][j-v];
							localMax = localMax >tmp? localMax:tmp;
						}
						localMax += Temps[k].value;
					}
					localMaxII = localMaxII>=localMax ? localMaxII: localMax;
				}
				max = max >= localMaxII? max: localMaxII;
			}
			trackerArray[i][j] = max;
		}
	}
	return trackerArray[length][width];
}