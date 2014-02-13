#include "stdafx.h"
#include "CppUnitTest.h"
#include "StackWithMin.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace CppTest
{
	TEST_CLASS(StackQueuetest)
	{
	public:
		
		TEST_METHOD(TestStackWithMin)
		{
			StackWithMin* _stack = new StackWithMin();

			_stack->Push(10);
			_stack->Push(5);
			_stack->Push(30);
			Assert::AreEqual(5, _stack->Min());

			_stack->Pop();
			Assert::AreEqual(5, _stack->Min());

			_stack->Push(1);
			Assert::AreEqual(1, _stack->Min());

			_stack->Pop();
			_stack->Pop();

			Assert::AreEqual(10, _stack->Min());
			
			_stack->Pop();
			_stack->Pop();
			_stack->Pop();
		}
	};
}