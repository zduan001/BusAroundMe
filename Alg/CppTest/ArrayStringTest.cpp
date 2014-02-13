#include "stdafx.h"
#include "CppUnitTest.h"
#include "ArrayStringmaster.h"
#include <string>
#include <vector>

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace CppTest
{		
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(TestArrangeArray)
		{
			ArrayStringMaster* target = new ArrayStringMaster();
			int input[] = {-1, 2, -3, 4, 5, 6, -7, 8, 9};
			target->ArrangeNegtivePositive(input,9);
			for(int i = 0;i< 7;i++)
			{
				if(i%2 ==0)
				{
					Assert::IsTrue(input[i]<0);
				}
				else
				{
					Assert::IsTrue(input[i] >0);
				}
			}
		}

		TEST_METHOD(Test_RemoveADoubleB)
		{
			ArrayStringMaster* target = new ArrayStringMaster();
			char input[] = "CAABD";
			target->RemoveADoubleB(input);
		}

		TEST_METHOD(Test_InterLeaving)
		{
			ArrayStringMaster * target = new ArrayStringMaster();
            char* s1 = "aabcc";
            char* s2 = "dbbca";
            char* s3 = "aadbbcbcac";
			bool actual = target->CheckInterLeave(s1, s2, s3);
			Assert::IsTrue(actual);

			s3 = s3 = "aadbbbaccc";
			actual = target->CheckInterLeave(s1, s2, s3);
			Assert::IsFalse(actual);
		}

		TEST_METHOD(Test_FindMaxConseq)
		{
			ArrayStringMaster* target = new ArrayStringMaster();
			std::string input = "this is a sentence";
			std::vector<char> actual = target->FindMaxConseq(input);

			input = "thiis iss a senntencee";
			actual = target->FindMaxConseq(input);

			input = "thiisss iss a senntttenceee";
			actual = target->FindMaxConseq(input);

			input = "thiisss iss a sennnntttenceee";
			actual = target->FindMaxConseq(input);
		}

		TEST_METHOD(test_FindLongestRepeatSubStr)
		{
			ArrayStringMaster* target = new ArrayStringMaster();
			string input = "abcabcaacb";
			vector<char> actual = target->FindLongestRepeatSubStr(input);

			Assert::AreEqual('a', actual[0]);
			Assert::AreEqual('b', actual[1]);
			Assert::AreEqual('c', actual[2]);
			Assert::AreEqual('a', actual[3]);

			input = "aababa";
			actual = target->FindLongestRepeatSubStr(input);
			Assert::AreEqual('a', actual[0]);
			Assert::AreEqual('b', actual[1]);
			Assert::AreEqual('a', actual[2]);
		}

		TEST_METHOD(Test_RandomNode)
		{
			ArrayStringMaster* target = new ArrayStringMaster();

			RandomNode* a = new RandomNode();
			a->data = 1;
			RandomNode* b = new RandomNode();
			b->data = 2;
			RandomNode* c = new RandomNode();
			c->data = 3;
			RandomNode* d = new RandomNode();
			d->data = 4;
			RandomNode* e = new RandomNode();
			e->data = 5;
			RandomNode* f = new RandomNode();
			f->data = 6;

			a->next = b;
			b->next = c;
			c->next = d;
			d->next = e;
			e->next = f;

			a->extra = c;
			b->extra = a;
			c->extra = d;
			d->extra = b;
			e->extra = f;
			f->extra = e;

			RandomNode* actual = target->CloneRandomNode(a);

			Assert::AreEqual(actual->data, a->data);
			Assert::AreEqual(actual->next->data, a->next->data);
			Assert::AreEqual(actual->extra->data, a->extra->data);
			Assert::AreEqual(actual->next->next->data, a->next->next->data);
		}

		TEST_METHOD(TestCleanString)
		{
			ArrayStringMaster * target = new ArrayStringMaster();

			char input[] = "acbac";
			target->CleanString(input);
			Assert::AreEqual('\0', input[0]);

			char input1[] = "aaac";
			target->CleanString(input1);
			Assert::AreEqual('a', input1[0]);
			Assert::AreEqual('a', input1[1]);
			Assert::AreEqual('\0', input1[2]);

			char input2[] = "ababac";
			target->CleanString(input2);
			Assert::AreEqual('a', input2[0]);
			Assert::AreEqual('a', input2[1]);
			Assert::AreEqual('\0', input2[2]);

			char input3[] = "bbbbd";
			target->CleanString(input3);
			Assert::AreEqual('d', input3[0]);
			Assert::AreEqual('\0', input3[1]);

			char input4[] = "adc";
			target->CleanString(input4);
			Assert::AreEqual('a', input4[0]);
			Assert::AreEqual('d', input4[1]);
			Assert::AreEqual('c', input4[2]);
			Assert::AreEqual('\0', input4[3]);

			char input5[] = "aabc";
			target->CleanString(input5);
			Assert::AreEqual('a', input5[0]);
			Assert::AreEqual('\0', input5[1]);
		}

		TEST_METHOD(TestClranStringII)
		{
			ArrayStringMaster * target = new ArrayStringMaster();

			char input[] = "acbac";
			char* actual = target->CleanStringII(input);
			Assert::AreEqual('\0', actual[0]);

			char input1[] = "aaac";
			actual = target->CleanStringII(input1);
			Assert::AreEqual('a', actual[0]);
			Assert::AreEqual('a', actual[1]);
			Assert::AreEqual('\0', actual[2]);

			char input2[] = "ababac";
			actual = target->CleanStringII(input2);
			Assert::AreEqual('a', actual[0]);
			Assert::AreEqual('a', actual[1]);
			Assert::AreEqual('\0', actual[2]);

			char input3[] = "bbbbd";
			actual = target->CleanStringII(input3);
			Assert::AreEqual('d', actual[0]);
			Assert::AreEqual('\0', actual[1]);

			char input4[] = "adc";
			actual = target->CleanStringII(input4);
			Assert::AreEqual('a', actual[0]);
			Assert::AreEqual('d', actual[1]);
			Assert::AreEqual('c', actual[2]);
			Assert::AreEqual('\0', actual[3]);

			char input5[] = "aabc";
			actual = target->CleanStringII(input5);
			Assert::AreEqual('a', actual[0]);
			Assert::AreEqual('\0', actual[1]);

			char input6[] = "aaccedf";
			actual = target->CleanStringII(input6);
			Assert::AreEqual('e', actual[0]);
			Assert::AreEqual('d', actual[1]);
			Assert::AreEqual('f', actual[2]);
			Assert::AreEqual('\0', actual[3]);
		}
	};
}