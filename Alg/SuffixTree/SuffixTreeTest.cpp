#include "stdafx.h"
#include "CppUnitTest.h"
#include "SuffixTree.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace SuffixTree
{
	TEST_CLASS(SuffixTreeTest)
	{
	public:
		
		TEST_METHOD(Test_SuffixTree)
		{
			CSuffixTree* target = new CSuffixTree();
			target->CreateSuffixTree("av");
			Assert::IsNotNull(target->children[0]);
		}

	};
}