#include "stdafx.h"
#include "CppUnitTest.h"
#include "TreeNodeWithNext.h"
#include "TreeQuestion.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace TreeQuestions
{		
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(TestPoupulateNextRightPointersInEachNode)
		{
			TreeNodeWithNext* tmp = new TreeNodeWithNext();
			int input[] = {-1,0,1,2,3,4,5,6,7,8,9,10,11,12,13};
			TreeNodeWithNext* root = tmp->ConstructTreeNodeWithNext(input, 15,0);

			TreeQuestion* target = new TreeQuestion();
			target->PoupulateNextRightPointersInEachNode(root);
			Assert::IsTrue(root->left->next == root->right);
			Assert::IsTrue(root->left->right->next == root->right->left);
		}

		TEST_METHOD(IITestPoupulateNextRightPointersInEachNodeII)
		{
			TreeNodeWithNext* tmp = new TreeNodeWithNext();
			int input[] = {-1,0,1,2,3,4,5,6,7,8,9,10,11,12,13};
			TreeNodeWithNext* root = tmp->ConstructTreeNodeWithNext(input, 15,0);

			TreeQuestion* target = new TreeQuestion();
			target->PoupulateNextRightPointersInEachNodeII(root);
			Assert::IsTrue(root->left->next == root->right);
			Assert::IsTrue(root->left->right->next == root->right->left);
		}

	};
}